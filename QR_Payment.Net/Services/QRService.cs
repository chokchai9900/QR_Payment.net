using QR_Payment.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QR_Payment.Net.Services
{
    public class QRService
    {
        private static readonly List<QRModel> Result = new List<QRModel>();
        private readonly List<string> Sublist = new List<string>() { "29", "30", "31", "32" };
        public List<QRModel> GetInfo(string QRBase)
        {
            if (Result != null)
            {
                Result.Clear();
            }
            Substring(QRBase);
            return Result;
        }

        private void Substring(string QRBase)
        {
            var Type = QRBase.Substring(0, 2);
            var dataLength = QRBase.Substring(2, 2);
            var dataString = QRBase.Substring(4, int.Parse(dataLength));

            var result = new QRModel
            {
                DataType = Type,
                DataLength = dataLength,
                Data = dataString
            };
            if (Sublist.Contains(Type))
            {
                var subHeader = new QRModel
                {
                    DataType = Type,
                    DataLength = dataLength
                };
                Result.Add(subHeader);

                GetSubInfo(dataString, Type);
            }
            else
            {
                Result.Add(result);
            }
            var count = Type.Length + dataLength.Length + dataString.Length;
            var newQRString = QRBase.Remove(0, count);

            if (newQRString.Length > 0)
            {
                Substring(newQRString);
            }
        }

        private static void GetSubInfo(string QRSub, string Basetype)
        {
            var Type = QRSub.Substring(0, 2);
            var dataLength = QRSub.Substring(2, 2);
            var dataString = QRSub.Substring(4, int.Parse(dataLength));
            var result = new QRModel
            {
                DataType = $"{Basetype}_{Type}",
                DataLength = dataLength,
                Data = dataString
            };
            Result.Add(result);

            var count = Type.Length + dataLength.Length + dataString.Length;
            var newQRString = QRSub.Remove(0, count);
            if (newQRString.Length > 0) GetSubInfo(newQRString, Basetype);
        }
    }
}
