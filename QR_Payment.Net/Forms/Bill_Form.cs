using MessagingToolkit.QRCode.Codec.Data;
using QR_Payment.Net.Models;
using QR_Payment.Net.Services;
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
        public readonly QRService service = new QRService();
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
        public void GetInfoToTextBox(List<QRModel> QrData)
        {
            QRVersion.Text = QrData.Find(it => it.DataType == "00").Data;
            QRType.Text = QrData.Find(it => it.DataType == "01").Data;
            ApplicationID.Text = QrData.Find(it => it.DataType == "30_00").Data;
            BillerID.Text = QrData.Find(it => it.DataType == "30_01").Data;
            Ref1.Text = QrData.Find(it => it.DataType == "30_02").Data;
            Ref2.Text = QrData.Find(it => it.DataType == "30_03").Data;
            CurrencyID.Text = QrData.Find(it => it.DataType == "53").Data;
            Amount.Text = QrData.Find(it => it.DataType == "54").Data;
            CountryCode.Text = QrData.Find(it => it.DataType == "58").Data;
            MerchantName.Text = QrData.Find(it => it.DataType == "59").Data;
            Ref3.Text = QrData.Find(it => it.DataType == "62").Data;
            CheckSum.Text = QrData.Find(it => it.DataType == "63").Data;

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

        private void Ref3_button_Click(object sender, EventArgs e)
        {
            CopyClipboardEvent(Ref3);
        }

        private void CRC_button_Click(object sender, EventArgs e)
        {
            CopyClipboardEvent(CheckSum);
        }

        private void GenerateQR_Click(object sender, EventArgs e)
        {
            var result = service.GetInfo(QRString.Text);
            GetInfoToTextBox(result);
        }

        private void SelectQRImage_Click(object sender, EventArgs e)
        {
            GetQRImage();
        }
    }
}
