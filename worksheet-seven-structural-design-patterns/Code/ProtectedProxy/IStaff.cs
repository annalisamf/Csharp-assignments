namespace ProtectedProxy
{
    public interface IStaff
    {
        public bool IsOwner();
        public IReportGeneratorProxy ReportGenerator { get; set; }
    }
}