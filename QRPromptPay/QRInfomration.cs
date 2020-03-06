using PromptPayQR;
using QRPromptPay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QRPromptPay
{
    public class QRInfomration : IQRInfo
    {
        public string CreateQRString(QRInfo data)
        {
            var EMVCo = "000201";
            var applicationID = "0016A000000677010112";

            var billPaymentBillerID = data.BillerId;
            var reference1 = $"02{fieldIsNull(data.Ref1)}";
            var reference2 = $"03{fieldIsNull(data.Ref2)}";
            
            // Amount
            var amount = Convert.ToDouble(data.Amount).ToString("0.00");
            var digits = string.Format("{0:00}", amount.Length);
            var shouldFormat = !string.IsNullOrEmpty(data.Amount);
            var transactionAmount = shouldFormat ? $"54{digits}{amount}" : string.Empty;

            var transactionCurrency = $"53{fieldIsNull(data.Currency)}"; // รหัสสกุลเงิน
            var countryCode = $"58{fieldIsNull(data.CountryCode)}";
            var qrUse = "010212";
            var billPayment = $"{applicationID}{billPaymentBillerID}{reference1}{reference2}";
            var billPaymentInfo = $"30{fieldIsNull(billPayment)}";
            var qrcode = new StringBuilder();
            const string CheckSum = "6304";
            qrcode.Append(EMVCo)
                     .Append(qrUse)
                     .Append(billPaymentInfo)
                     .Append(transactionCurrency)
                     .Append(transactionAmount)
                     .Append(countryCode)
                     .Append(CheckSum);

            var payload = qrcode.ToString().Select(x => Convert.ToByte(x)).ToArray();
            var crc = new CRC16().ComputeCheckSum(payload);
            var crc16 = crc.ToString("X").PadLeft(4, '0');
            qrcode.Append(crc16);
            return qrcode.ToString();

        }

        public static string fieldIsNull(string value)
        {
            var digits = (value ?? string.Empty).Length.ToString("00");
            return $"{digits}{value}";
        }
    }
}
