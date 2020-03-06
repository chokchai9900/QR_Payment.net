using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QR_Payment.Net
{
    public interface IQR
    {
        string Create(QRData data);
        QRInfo Read(string text);
    }

    public class QRData
    {
        public string BillerId { get; set; }
        public string Suffix { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Currency { get; set; }
        public string CountryCode { get; set; }

        public string Amount { get; set; }
        public string MerchantName { get; set; }
        public string MerchantNo { get; set; }
        public string PointOfInherite { get; set; }
    }
    public class QRInfo : QRData
    {
        public string CheckSum { get; set; }
        public string Version { get; set; }
        public string Pattern { get; set; }
        public string AppId { get; set; }

        /// <summary>
        /// โอนเงินบุคคล, จ่ายเงินร้าน
        /// </summary>
        public string Type { get; set; }
    }
}
