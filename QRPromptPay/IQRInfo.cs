using QRPromptPay.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QRPromptPay
{
    public interface IQRInfo
    {
        string CreateQRString(QRInfo data);
        //QRStringModel QRInfomation(string QRString);
    }
}
