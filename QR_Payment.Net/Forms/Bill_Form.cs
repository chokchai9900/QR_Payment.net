using MessagingToolkit.QRCode.Codec.Data;
using QR_Payment.Net.Class;
using QR_Payment.Net.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Payment.Net
{
    public partial class Bill_Form : Form
    {

        public QRService service = new QRService();

        public Bill_Form()
        {
            InitializeComponent();
        }

        public void CopyClipboardEvent(TextBox text)
        {
            Clipboard.SetText(text.Text);
            MessageBox.Show($"{text.Name} is Copy !!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void GetQRImage()
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "JPEG|*.jpg",
                ValidateNames = true,
                Multiselect = false
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                    QRString.Text = decoder.Decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap));
                }
            }
        }
        public void GetInfoToTextBox(List<QRStringModel> QrData)
        {
            var Getdata = QrData.FirstOrDefault();

            QRVersion.Text = Getdata?.Version.Data ?? "";
            QRType.Text = Getdata?.Type.Data ?? "";
            ApplicationID.Text = Getdata?.AID.Data ?? "";
            BillerID.Text = Getdata?.Biller.Data ?? "";
            Ref1.Text = Getdata?.Reference1.Data ?? "";
            Ref2.Text = Getdata?.Reference2.Data ?? "";
            CurrencyID.Text = Getdata?.Currency.Data ?? "";
            Amount.Text = Getdata?.amount.Data ?? "";
            CountryCode.Text = Getdata?.Country.Data ?? "";
            MerchantName.Text = Getdata?.Name.Data ?? "";
            CheckSum.Text = Getdata?.CheckSumCRC16.Data ?? "";
        }

        private void CopyClipboard_button_Click(object sender, EventArgs e)
        {
            CopyClipboardEvent(QRString);
        }

        private void VersionQR_button_Click(object sender, EventArgs e)
        {
            CopyClipboardEvent(QRVersion);
        }

        private void QRFormat_button_Click(object sender, EventArgs e)
        {
            CopyClipboardEvent(QRType);
        }

        private void AppID_button_Click(object sender, EventArgs e)
        {
            CopyClipboardEvent(ApplicationID);
        }

        private void BillerID_button_Click(object sender, EventArgs e)
        {
            CopyClipboardEvent(BillerID);
        }

        private void Ref1_button_Click(object sender, EventArgs e)
        {
            CopyClipboardEvent(Ref1);
        }

        private void Ref2_button_Click(object sender, EventArgs e)
        {
            CopyClipboardEvent(Ref2);
        }

        private void CurrencyID_button_Click(object sender, EventArgs e)
        {
            CopyClipboardEvent(CurrencyID);
        }

        private void Amount_button_Click(object sender, EventArgs e)
        {
            CopyClipboardEvent(Amount);
        }

        private void CountryCode_button_Click(object sender, EventArgs e)
        {
            CopyClipboardEvent(CountryCode);
        }

        private void MerchantName_button_Click(object sender, EventArgs e)
        {
            CopyClipboardEvent(MerchantName);
        }

        private void CRC_button_Click(object sender, EventArgs e)
        {
            CopyClipboardEvent(CheckSum);
        }

        private void GenerateQR_Click(object sender, EventArgs e)
        {
            var result = service.GetInfo(QRString.Text);
            var condition = result.Find(it => it.Type.DataType.Contains("29"))?.ToString();
            if (!string.IsNullOrEmpty(condition))
            {
                label14.Text = "Phone Number";
                label13.Text = "Identity ID";
                label8.Text = "E-wallet ID";
            }
            else
            {
                label14.Text = "Biller ID";
                label13.Text = "Reference 1";
                label8.Text = "Reference 2";
            }
            GetInfoToTextBox(result);

        }

        private void SelectQRImage_Click(object sender, EventArgs e)
        {
            GetQRImage();
        }
    }
}
