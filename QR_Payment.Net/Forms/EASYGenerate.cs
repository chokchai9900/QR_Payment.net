using QR_Payment.Net.Class;
using QR_Payment.Net.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Payment.Net.Forms
{
    public partial class EASYGenerate : Form
    {
        public EASYGenerate()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var encodeModel = new IQRGenterate
            {
                Ref1 = txtRef1.Text,
                Ref2 = txtRef2.Text,
                Amount = txtAmount.Text,          
            };
            var generate = new QRGenerate();
            string qrString = generate.CreateQRString(encodeModel);
            ID.Text = qrString;
            var imageQR = PromptPayQR.PromptPayQR.QRCodeImage(qrString);
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
    }
}
