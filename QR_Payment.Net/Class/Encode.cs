using PromptPayQR;
using QR_Payment.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QR_Payment.Net.Class
{
    class Encode
    {
        public static string QRCodeLongText(QREncodeModel qrEncode)
        {
            var EMVCo = "000201";
            var applicationID = "0016A000000677010112";
            var BillerID = $"{qrEncode.TaxID}{qrEncode.Suffix}";
            var defaultBiller = "00000000000001";
            var billPaymentBillerID = !String.IsNullOrEmpty(BillerID)? $"01{fieldIsNull(BillerID)}": $"01{fieldIsNull(defaultBiller)}";
            var reference1 = $"02{fieldIsNull(qrEncode.Ref1)}";
            var reference2 = $"03{fieldIsNull(qrEncode.Ref2)}";
            var transactionAmount = "";
            if (!String.IsNullOrEmpty(qrEncode.Amount))
            {
                var amount = String.Format("{0:0.00}", Convert.ToDouble(qrEncode.Amount));
                transactionAmount = $"54{len(amount)}{amount}";
            }
            else
            {
                transactionAmount = "";
            }
            var transactionCurrency = !String.IsNullOrEmpty(qrEncode.Currency) ? $"5303{qrEncode.Currency}" : $"5303764";
            var countryCode = !String.IsNullOrEmpty(qrEncode.CountryCode) ? $"5802{qrEncode.CountryCode}" : "5802TH";
            var merchantName = !String.IsNullOrEmpty(qrEncode.MerchantName) ? $"59{fieldIsNull(qrEncode.MerchantName)}" : "";
            var terminalNumber = !String.IsNullOrEmpty(qrEncode.TerminalNumber) ? $"62{fieldIsNull(qrEncode.TerminalNumber)}" : "";
            var qrUse = qrEncode.Usese == "No" ? "010212" : "010211";
            var billPayment = $"{applicationID}{billPaymentBillerID}{reference1}{reference2}";
            var billPaymentInfo = $"30{fieldIsNull(billPayment)}";
            var qrcode = new StringBuilder();
            qrcode.Append(EMVCo)
                     .Append(qrUse)
                     .Append(billPaymentInfo)
                     .Append(transactionCurrency)
                     .Append(transactionAmount)
                     .Append(countryCode)
                     .Append(merchantName)
                     .Append(terminalNumber)
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
