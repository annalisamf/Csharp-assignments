namespace Adapter
{
    public class XpayToPayD
    {
        public static IPayD XpayToPayDAdapter(IXPay ixp)
        {
            IPayD ipd = new PayDImpl();
            ipd.CvvNo = ixp.CardCvvNo;
            ipd.CardOwnerName = ixp.CustomerName;
            ipd.TotalAmount = (decimal)ixp.Amount;
            ipd.CustCardNo = ixp.CreditCardNo;
            ipd.CardExpMonthDate = ixp.CardExpMonth;
            return ipd;
        }
                      
        
        private class PayDImpl : IPayD
        {
            public string CustCardNo { get; set; }
            public string CardOwnerName { get; set; }
            public string CardExpMonthDate { get; set; }
            public int CvvNo { get; set; }
            public decimal TotalAmount { get; set; }
        }
    }
}