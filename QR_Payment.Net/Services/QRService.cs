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
        private static readonly List<QRStringModel> finalResult = new List<QRStringModel>();
        private static readonly List<QRModel> Result = new List<QRModel>();
        private readonly List<string> Sublist = new List<string>() { "29", "30", "31", "32" };
        public List<QRStringModel> GetInfo(string QRBase)
        {
            if (Result != null)
            {
                Result.Clear();
            }
            Substring(QRBase);
            QRDetail(Result);
            return finalResult;
        }
        private void QRDetail(List<QRModel> QrData)
        {
            var QRVersion = SortDataMain("00", QrData);
            var QRType = SortDataMain("01", QrData);
            var ApplicationID = SortDataSubField("30_00", "29_00", QrData);
            var BillerID = SortDataSubField("30_01", "29_01", QrData);
            var Ref1 = SortDataSubField("30_02", "29_02", QrData);
            var Ref2 = SortDataSubField("30_03", "29_03", QrData);
            var CurrencyID = SortDataMain("53", QrData);
            var Amount = SortDataMain("54", QrData);
            var CountryCode = SortDataMain("58", QrData);
            var MerchantName = SortDataMain("59", QrData);
            var CheckSum = SortDataMain("63", QrData);

            var qrdetail = new QRStringModel
            {
                Version = QRVersion,
                Type = QRType,
                AID = ApplicationID,
                Biller = BillerID,
                Reference1 = Ref1,
                Reference2 = Ref2,
                Currency = CurrencyID,
                Country = CountryCode,
                amount = Amount,
                Name = MerchantName,
                CheckSumCRC16 =CheckSum
            };
            finalResult.Add(qrdetail);
        }

        private QRModel SortDataSubField(string Conditionperfix1, string Conditionperfix2, List<QRModel> qrListString)
        {
            var SelectedData = new QRModel
            {
                DataType = qrListString.Find(it => it.DataType == $"{Conditionperfix1}" || it.DataType == $"{Conditionperfix2}")?.DataType ?? "",
                DataLength = qrListString.Find(it => it.DataType == $"{Conditionperfix1}" || it.DataType == $"{Conditionperfix2}")?.DataLength ?? "",
                Data = qrListString.Find(it => it.DataType == $"{Conditionperfix1}" || it.DataType == $"{Conditionperfix2}")?.Data ?? "",
            };
            return SelectedData;
        }
        private QRModel SortDataMain(string perfix,List<QRModel> qrListString)
        {
            var SelectedData = new QRModel
            {
                DataType = qrListString.Find(it => it.DataType == $"{perfix}")?.DataType ?? "",
                DataLength = qrListString.Find(it => it.DataType == $"{perfix}")?.DataLength ?? "",
                Data = qrListString.Find(it => it.DataType == $"{perfix}")?.Data ?? "",
            };
            return SelectedData;
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
