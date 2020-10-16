namespace ProtectedProxy
{
    public interface IReportGeneratorProxy : IReportGenerator
    {
        public string GenerateDailyReport();
    }
}