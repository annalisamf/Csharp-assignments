using System;
using System.Collections.Generic;
using System.Linq;
using LaYumba.Functional;
using static LaYumba.Functional.F;


namespace Q9
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var employees = new Dictionary<string, Employee>();
            employees.Add("Anna", new Employee{Id = "Anna", WorkPermit = 
                Some(new WorkPermit{Number = "256", Expiry = DateTime.Now.AddDays(-1)})});
        }

        private static double AverageYearsWorkedAtTheCompany(IEnumerable<Employee> employees)
            => employees
                .Bind(e => e.LeftOn.Map(leftOn => YearsBetween(e.JoinedOn, leftOn)))
                .Average();

        private static double YearsBetween(DateTime start, DateTime end)
            => (end - start).Days / 365d;

        private struct WorkPermit
        {
            public string Number { get; set; }
            public DateTime Expiry { get; set; }
        }

        private class Employee
        {
            public string Id { get; set; }
            public Option<WorkPermit> WorkPermit { get; set; }

            public DateTime JoinedOn { get; }
            public Option<DateTime> LeftOn { get; }
        }
    }
}

