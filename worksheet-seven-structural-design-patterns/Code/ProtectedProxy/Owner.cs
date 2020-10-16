using System;

namespace ProtectedProxy
{
    public class Owner : IStaff
    {
        private readonly bool _isOwner = true;
        public bool IsOwner()
        {
            return _isOwner;
        }

        public string GenerateDailyReport()
        {
            try
            {
                return ReportGenerator.GenerateDailyReport();
            }
            catch (Exception e)

            {
                Console.WriteLine(e);
                throw;
            }

        }

        public IReportGeneratorProxy ReportGenerator { get; set; }
    }
}