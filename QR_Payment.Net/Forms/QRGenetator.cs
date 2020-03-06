using PromptPayQR;
using QR_Payment.Net.Class;
using QR_Payment.Net.Interface;
using QR_Payment.Net.Models;
using QRPromptPay;
using System;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace QR_Payment.Net
{
    public partial class QRGenetator : Form
    {
        public QRGenetator()
        {
            InitializeComponent();
        }

        private void generate_Btn_Click(object sender, EventArgs e)
        {
            var encodeModel = new QRPromptPay.Models.QRInfo
            {
                TaxID = txtTaxID.Text,
                Suffix = txtSuffix.Text,
                Ref1 = txtRef1.Text,
                Ref2 = txtRef2.Text,
                Amount = txtAmount.Text,
                Currency = txtCurrency.Text,
                CountryCode = txtCountryCode.Text,
                MerchantName = txtMerchantName.Text,
                TerminalNo = txtTerminalNumber.Text,
                PointOfInherite = cbUsese.Text == "No" ? "11":"12" 
            };

            var qrString = new QRInfomration()
                .CreateQRString(encodeModel);

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

        private void copyClipboard_button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ID.Text);
        }

        private void QRGenetator_Load(object sender, EventArgs e)
        {
            cbUsese.SelectedIndex = 1;
        }
    }
}
