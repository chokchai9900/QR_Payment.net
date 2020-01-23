using PromptPayQR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Payment.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generate_Btn_Click(object sender, EventArgs e)
        {
            var promptpayID = ID_textBox.Text;
            var amount = amount_textbox.Value.ToString();
            if (amount.Contains("0"))
            {
                amount = "";
            }

            //var qrCode = PromptPayQR.QRCodePayload(promptpayID, amount);
            var qrCode = PromptPayQR.PromptPayQR.QRCodePayload(promptpayID, amount);
            ID.Text = qrCode;
            var imageQR = PromptPayQR.PromptPayQR.QRCodeImage(qrCode);
            QRBox.Image = imageQR;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "JPEG|*.jpg",
                ValidateNames = true
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    QRBox.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                }
            }
        }

        private void copyClipboard_button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ID.Text);
        }
    }
}
