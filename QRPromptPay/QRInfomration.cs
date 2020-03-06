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
            var qrcode = data.GetQrCode();
            var payload = Encoding.ASCII.GetBytes(qrcode);
            var crc = new CRC16().ComputeCheckSum(payload);
            var crc16 = crc.ToString("X").PadLeft(4, '0');
            qrcode = $"{qrcode}{crc16}";
            return qrcode.ToString();
        }
    }
}
