using QRPromptPay.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QRPromptPay
{
    public static class QRGeneratorHelper
    {
        public static string QrUse(this QRInfo data)
            => data.PointOfInherite.AdjustFormat(QRSegment.QRUse);

        public static string BillPayment(this QRInfo data)
        {
            var billerId = $"{data.TaxID}{data.Suffix}".AdjustFormat(QRSegment.BillerId);
            var ref1 = data.Ref1.AdjustFormat(QRSegment.Ref1);
            var ref2 = data.Ref2.AdjustFormat(QRSegment.Ref2);
            var buildPaymentId = $"{data.ApplicationID}{billerId}{ref1}{ref2}";
            return buildPaymentId.AdjustFormat(QRSegment.BillPayment);
        }

        public static string TrancactionCurrency(this QRInfo data)
            => data.Currency.AdjustFormat(QRSegment.TrancactionCurrency);

        public static string TransactionAmount(this QRInfo data)
        {
            if (string.IsNullOrEmpty(data.Amount))
            {
                return string.Empty;
            }

            var amount = Convert.ToDouble(data.Amount).ToString("0.00");
            return amount.AdjustFormat(QRSegment.TransactionAmount);
        }
        public static string CountryCode(this QRInfo data)
            => data.CountryCode.AdjustFormat(QRSegment.CountryCode);

        public static string GetQrCode(this QRInfo data)
        {
            var qrUse = data.QrUse();
            var billPayment = data.BillPayment();
            var trancactionCurrency = data.TrancactionCurrency();
            var transactionAmount = data.TransactionAmount();
            var countryCode = data.CountryCode();
            const string CheckSum = "6304";
            return $"{data.EMVCo}{qrUse}{billPayment}{trancactionCurrency}{transactionAmount}{countryCode}{CheckSum}";
        }

        public static string AdjustFormat(this string value, QRSegment segment)
        {
            var segmentNo = (int)segment;
            var prefix = segmentNo.ToString("00");
            var digits = getDigits(value);
            return $"{prefix}{digits}{value}";
        }

        private static string getDigits(string value) => (value ?? string.Empty).Length.ToString("00");
    }

    public enum QRSegment
    {
        // Main
        QRUse = 1,
        BillPayment = 30,
        TrancactionCurrency = 53,
        CountryCode = 58,
        TransactionAmount = 54,

        // Sub
        BillerId = 1,
        Ref1 = 2,
        Ref2 = 3,
    }
}
