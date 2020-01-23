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
           
            var EMVCo = "000201";
            var qrUse = (cbUse.Text=="single")? "010212" : "010211";
            var applicationID = "0016A000000677010112";
            var billPaymentTaxID = txtTaxID.Text;
            var billPaymentSuffix = txtSuffix.Text;
            var BillerID = $"{billPaymentTaxID}{billPaymentSuffix}";
            var billPaymentBillerID = $"01{len(BillerID)}{BillerID}";
            var reference1 = $"02{len(txtRef1.Text)}{txtRef1.Text}";
            var reference2 = $"03{len(txtRef2.Text)}{txtRef2.Text}";
            var billPayment = $"{applicationID}{billPaymentBillerID}{reference1}{reference2}";
            var billPaymentInfo = $"30{len(billPayment)}{billPayment}";
            var transactionCurrency = "5303764";
            var transactionAmount = "";
            if (!String.IsNullOrEmpty(txtAmount.Text)) {
                var amount = String.Format("{0:0.00}", Convert.ToDouble(txtAmount.Text));
                transactionAmount = $"54{len(amount)}{amount}";
            }
            else {
                transactionAmount = "";
            }
            var countryCode = "5802TH";
            var qrcode = $"{EMVCo}{qrUse}{billPaymentInfo}{transactionCurrency}{transactionAmount}{countryCode}6304";
            var payload = qrcode.ToString().Select(x => Convert.ToByte(x)).ToArray();
            var crc = new CRC16().ComputeCheckSum(payload);
            var crc16 = crc.ToString("X").PadLeft(4, '0');
            qrcode = $"{qrcode}{crc16}";
            var qrCode = PromptPayQR.PromptPayQR.QRCodePayload(qrcode);
            ID.Text = qrCode;
            var imageQR = PromptPayQR.PromptPayQR.QRCodeImage(qrCode);
            QRBox.Image = imageQR;
            subText();
        }
        public static string len(string str)
        {
            var strLen=(str.Length < 10) ? $"0{str.Length}" : str.Length.ToString();
            return strLen;
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
        public static void subText() {
            var str = "00020101021130550016A00000067701011201150135560022933020204ref10304ref253037645802TH63048FC2";
            var li = new List();
            for(int i=0;i<str.Length;i++){
                Console.WriteLine(str[i]);

            }
        }
        private void copyClipboard_button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ID.Text);
        }
    }
}
