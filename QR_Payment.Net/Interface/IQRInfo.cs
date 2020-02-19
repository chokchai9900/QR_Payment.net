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
        string CreateQRString(QRData qrData);
        QRInfo QRInfomation(string QRString);
    }

    public class QRData
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

    public class QRInfo 
    {

    }
}
