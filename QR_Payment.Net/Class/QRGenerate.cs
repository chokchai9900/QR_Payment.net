using PromptPayQR;
using QR_Payment.Net.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QR_Payment.Net.Class
{
    class QRGenerate : IQRGenerate
    {
        public string CreateQRString(IQRGenterate qrData)
        {
            var EMVCo = "000201";
            var applicationID = "0016A000000677010112";
            var billPaymentBillerID = "01100000000001";
            var reference1 = $"02{fieldIsNull(qrData.Ref1)}";
            var reference2 = $"03{fieldIsNull(qrData.Ref2)}";
            var transactionAmount="";
            if (!String.IsNullOrEmpty(qrData.Amount))
            {
                var amount = String.Format("{0:0.00}", Convert.ToDouble(qrData.Amount));
                transactionAmount = $"54{len(amount)}{amount}";
            }
            else
            {
                transactionAmount = "";
            }
            var transactionCurrency =  "5303764";
            var countryCode =  "5802TH";
            var qrUse = "010212" ;
            var billPayment = $"{applicationID}{billPaymentBillerID}{reference1}{reference2}";
            var billPaymentInfo = $"30{fieldIsNull(billPayment)}";
            var qrcode = new StringBuilder();
            qrcode.Append(EMVCo)
                     .Append(qrUse)
                     .Append(billPaymentInfo)
                     .Append(transactionCurrency)
                     .Append(transactionAmount)
                     .Append(countryCode)
                     .Append("6304");
            var payload = qrcode.ToString().Select(x => Convert.ToByte(x)).ToArray();
            var crc = new CRC16().ComputeCheckSum(payload);
            var crc16 = crc.ToString("X").PadLeft(4, '0');
            qrcode.Append(crc16);
            return qrcode.ToString();
            
        }

        public static string fieldIsNull(string str)
        {
            return string.IsNullOrEmpty(str) ? "" : $"{len(str)}{str}";
        }
        public static string len(string str)
        {
            var strLen = (str.Length < 10) ? $"0{str.Length}" : str.Length.ToString();
            return strLen;
        }
    }
}
