using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QR_Payment.Net.Models
{
     class QREncodeModel
    {
        public string TaxID { get; set; }
        public string Suffix { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Amount { get; set; }
        public string Currency { get; set; }
        public string CountryCode { get; set; }
        public string MerchantName { get; set; }
        public string TerminalNumber { get; set; }
        public string Usese { get; set; }
        

    }
}
