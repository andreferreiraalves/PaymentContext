using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode, string boletoNumer, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Adress adress, Email email) :
        base(paidDate, expireDate, total, totalPaid, payer, document, adress, email)
        {
            BarCode = barCode;
            BoletoNumer = boletoNumer;
        }

        public string BarCode { get; private set; }
        public string BoletoNumer { get; private set; }
    }
}