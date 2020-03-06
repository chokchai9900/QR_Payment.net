using System;
using System.Collections.Generic;
using System.Text;

namespace QRPromptPay.Models
{
    public class QRMetadata
    {
        private readonly QRInfo data;

        public QRMetadata(QRInfo data)
        {
            this.data = data;
        }

        /// <summary>
        /// Main field
        /// </summary>
        private string EMVCo => "000201";
        private string QRUse => $"01{getDigits(data.PointOfInherite)}{data.PointOfInherite}";
        private string TransactionAmount
        {
            get
            {
                if (string.IsNullOrEmpty(data.Amount))
                {
                    return string.Empty;
                }

                var amount = Convert.ToDouble(data.Amount).ToString("0.00");
                return $"54{getDigits(amount)}{amount}";
            }
        }
        private string TrancactionCurrency => $"53{getDigits(data.Currency)}{data.Currency}";
        private string CountryCode => $"58{getDigits(data.CountryCode)}{data.CountryCode}";
        private string BillPayment => $"30{getDigits(BuildPaymentID)}{BuildPaymentID}";

        private string BuildPaymentID => $"{applicationID}{BillerId}{Ref1}{Ref2}";

        /// <summary>
        /// sub field
        /// </summary>
        private string applicationID => "0016A000000677010112";
        private string BillerId => $"01{getDigits($"{data.TaxID}{data.Suffix}")}{data.TaxID}{data.Suffix}";
        private string Ref1 => $"02{getDigits(data.Ref1)}{data.Ref1}";
        private string Ref2 => $"03{getDigits(data.Ref2)}{data.Ref2}";
        private const string CheckSum = "6304";
        public string QRCode => $"{EMVCo}{QRUse}{BillPayment}{TrancactionCurrency}{TransactionAmount}{CountryCode}{CheckSum}";

        private string getDigits(string value) => (value ?? string.Empty).Length.ToString("00");
    }
}
