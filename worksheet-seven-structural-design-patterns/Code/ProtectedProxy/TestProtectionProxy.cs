using System;

namespace ProtectedProxy
{
    public static class TestProtectionProxy
    {
        public static void Main(string[] args)
        {
            var owner = new Owner();

            var reportGenerator = new ReportGeneratorProtectionProxy(owner);
            owner.ReportGenerator = reportGenerator;

            var employee = new Employee();
            reportGenerator = new ReportGeneratorProtectionProxy(employee);
            employee.ReportGenerator = reportGenerator;

            Console.WriteLine("For owner:");
            Console.WriteLine(owner.GenerateDailyReport());

            Console.WriteLine("For employee:");
            Console.WriteLine(employee.GenerateDailyReport());
        }
    }
}
