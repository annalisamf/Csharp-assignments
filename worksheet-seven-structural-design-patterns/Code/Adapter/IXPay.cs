namespace Adapter
{
    public interface IXPay
    {
        public string CreditCardNo { get; set; }
        public string CustomerName { get; set; }
        public string CardExpMonth { get; set; }
        public string CardExpYear { get; set; }
        public short CardCvvNo { get; set; }
        public double Amount { get; set; }
    }
}