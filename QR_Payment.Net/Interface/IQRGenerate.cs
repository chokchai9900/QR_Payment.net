using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QR_Payment.Net.Interface
{
    public interface IQRGenerate
    {
        string CreateQRString(IQRGenterate qrData);
    }
    public class IQRGenterate
    {
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Amount { get; set; }
    }

}
