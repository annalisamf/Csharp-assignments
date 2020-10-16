namespace Adapter
{
    public interface IPayD
    {
        public string CustCardNo { get; set; }
        public string CardOwnerName { get; set; }
        public string CardExpMonthDate { get; set; }
        public int CvvNo { get; set; }
        public decimal TotalAmount { get; set; }
    }
}