using System;
using System.Drawing;
using System.Linq;
using System.Text;
using QRCoder;

namespace PromptPayQR
{
    public class PromptPayQR
    {
        public static string QRCodePayload(string qrcode)
        {     
            var builder = new StringBuilder();
            builder.Append(qrcode);     
            return builder.ToString(); 
        }

        public static Bitmap QRCodeImage(string qrcode)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(QRCodePayload(qrcode), QRCodeGenerator.ECCLevel.Q);
            return new QRCode(qrCodeData).GetGraphic(20);
        }

        public static Bitmap QRCodeImage(string payload,string a)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            return new QRCode(qrCodeData).GetGraphic(20);
        }

        private static string len(string str)
        {
            return str.Length.ToString().PadLeft(2, '0');
        }
    }
}
