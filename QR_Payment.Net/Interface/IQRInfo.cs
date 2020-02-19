using QR_Payment.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QR_Payment.Net.Interface
{
    public interface IQRInfo
    {
        string CreateQRString(QRInfo qrData);
        QRStringModel QRInfomation(string QRString);
    }

    public class QRInfo
    {
        public string TaxID { get; set; }
        public string Suffix { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Currency { get; set; }
        public string CountryCode { get; set; }
        public string Amount { get; set; }
        public string MerchantName { get; set; }
        public string TerminalNo { get; set; }
        public string PointOfInherite { get; set; }
    }

    public class QRData
    {
        public QRModel Version { get; set; }
        public QRModel Type { get; set; }
        public QRModel AID { get; set; }
        public QRModel Biller { get; set; }
        public QRModel Reference1 { get; set; }
        public QRModel Reference2 { get; set; }
        public QRModel Currency { get; set; }
        public QRModel amount { get; set; }
        public QRModel Country { get; set; }
        public QRModel Name { get; set; }
        public QRModel CheckSumCRC16 { get; set; }
    }

}
