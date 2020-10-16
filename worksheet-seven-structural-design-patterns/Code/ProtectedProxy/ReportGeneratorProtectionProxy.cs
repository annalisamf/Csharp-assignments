using System;
using System.Text.Json;
using System.Xml;

namespace ProtectedProxy
{
    public class ReportGeneratorProtectionProxy : IReportGeneratorProxy
    {
        private IReportGenerator reportGenerator;
        private readonly IStaff _staff;

        public ReportGeneratorProtectionProxy(IStaff staff)
        {
            this._staff = staff;
        }

        public string GenerateDailyReport()
        {
            if (_staff.IsOwner())
            {
                try
                {
                    Console.WriteLine("********************Location X Daily Report********************");
                    Console.WriteLine("Location ID: 012");
                    Console.WriteLine("Today's Date: Sun Sep 14 13:28:12 IST 2014");
                    Console.WriteLine("Total Pizza Sell: 112");
                    Console.WriteLine("Total Sale: $2534");
                    Console.WriteLine("Net Profit: $1985");
                    Console.WriteLine("***************************************************************");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                return "Not Authorized to view report";
            }

            return " ";
        }
    }
}