using System;

namespace ProtectedProxy
{
    public class Employee : IStaff
    {
        public bool IsOwner() => false;

        public string GenerateDailyReport()=> ReportGenerator.GenerateDailyReport();

        public IReportGeneratorProxy ReportGenerator { get; set; }
    }
}