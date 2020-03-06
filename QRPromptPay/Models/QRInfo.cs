using System;
using System.Collections.Generic;
using System.Text;

namespace QRPromptPay.Models
{
    public class QRInfo
    {
        public string TaxID { get; set; }
        public string Suffix { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Currency { get; set; } // สกุลเงิน
        public string CountryCode { get; set; } // upper case
        public string Amount { get; set; }
        public string MerchantName { get; set; }
        public string TerminalNo { get; set; }
        /// <summary>
        /// ใช้ซ้ำได้หรือไม่
        /// </summary>
        public string PointOfInherite { get; set; }
    }
}
