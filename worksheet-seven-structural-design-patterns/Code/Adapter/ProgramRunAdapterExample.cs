using System;

namespace Adapter
{
    internal static class ProgramRunAdapterExample
    {
        static void Main(string[] args)
        {
            // Object for Xpay
            IXPay xpay = new XpayImpl();
            xpay.CreditCardNo = "4789565874102365";
            xpay.CustomerName = "Max Warner";
            xpay.CardExpMonth = "09";
            xpay.CardExpYear = "25";
            xpay.CardCvvNo = 235;
            xpay.Amount = 2565.23;

            var payD = XpayToPayD.XpayToPayDAdapter(xpay);
            TestPayD(payD);
        }

        private static void TestPayD(IPayD payD)
        {
            Console.WriteLine(payD.CardOwnerName);
            Console.WriteLine(payD.CustCardNo);
            Console.WriteLine(payD.CardExpMonthDate);
            Console.WriteLine(payD.CvvNo);
            Console.WriteLine(payD.TotalAmount);
        }
    }
}