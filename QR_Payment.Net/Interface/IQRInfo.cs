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
    }

    public class QRInfo
    {

    }
}
