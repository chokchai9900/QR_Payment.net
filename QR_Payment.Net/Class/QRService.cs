using PromptPayQR;
using QR_Payment.Net.Interface;
using QR_Payment.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QR_Payment.Net.Class
{
    public class QRService : IQRInfo
    {
        private static readonly List<QRModel> Result = new List<QRModel>();
        private readonly List<string> Sublist = new List<string>() { "29", "30", "31", "32" };
        public QRStringModel QRInfomation(string QRString)
        {
            if (Result != null)
            {
                Result.Clear();
            }
            Substring(QRString);
            return QRDetail(Result);
        }
        private QRStringModel QRDetail(List<QRModel> QrData)
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
            return qrdetail;
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
        public string CreateQRString(QRInfo qrData)
        {
            var EMVCo = "000201";
            var applicationID = "0016A000000677010112";
            var BillerID = $"{qrData.TaxID}{qrData.Suffix}";
            var defaultBiller = "00000000000001";
            var billPaymentBillerID = !String.IsNullOrEmpty(BillerID) ? $"01{fieldIsNull(BillerID)}" : $"01{fieldIsNull(defaultBiller)}";
            var reference1 = $"02{fieldIsNull(qrData.Ref1)}";
            var reference2 = $"03{fieldIsNull(qrData.Ref2)}";
            var transactionAmount = "";
            if (!String.IsNullOrEmpty(qrData.Amount))
            {
                var amount = String.Format("{0:0.00}", Convert.ToDouble(qrData.Amount));
                transactionAmount = $"54{len(amount)}{amount}";
            }
            else
            {
                transactionAmount = "";
            }
            var transactionCurrency = !String.IsNullOrEmpty(qrData.Currency) ? $"5303{qrData.Currency}" : $"5303764";
            var countryCode = !String.IsNullOrEmpty(qrData.CountryCode) ? $"5802{(qrData.CountryCode).ToUpper()}" : "5802TH";
            var merchantName = !String.IsNullOrEmpty(qrData.MerchantName) ? $"59{fieldIsNull(qrData.MerchantName)}" : "";
            var terminalNumber = !String.IsNullOrEmpty(qrData.TerminalNo) ? $"62{fieldIsNull(qrData.TerminalNo)}" : "";
            var qrUse = qrData.PointOfInherite == "No" ? "010212" : "010211";
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
