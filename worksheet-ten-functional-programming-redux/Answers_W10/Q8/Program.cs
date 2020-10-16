using System;
using System.Collections.Generic;
using LaYumba.Functional;
using System.Linq;
using static LaYumba.Functional.F;


namespace Q8
{
    internal static class Program
    {
        private static void Main()
        {
            var employees = new Dictionary<string, Employee>();
            employees.Add("Anna", new Employee{Id = "Anna", WorkPermit = 
                Some(new WorkPermit{Number = "256", Expiry = DateTime.Now.AddDays(-1)})});

            var a = GetWorkPermit(employees, "Anna");

            var b = GetValidWorkPermit(employees, "Anna");
        }

        private static Option<WorkPermit> GetWorkPermit(Dictionary<string, Employee> employees, string employeeId)
            => employees.Lookup(employeeId).Bind(e => e.WorkPermit);

        // Augmented implementation to return none if the work permit has expired
        private static Option<WorkPermit> GetValidWorkPermit(Dictionary<string, Employee> employees, string employeeId)
            => employees
                .Lookup(employeeId)
                .Bind(e => e.WorkPermit)
                .Where(HasExpired.Negate());

        private static Func<WorkPermit, bool> HasExpired => permit => permit.Expiry < DateTime.Now.Date;

        private struct WorkPermit
        {
            public string Number { get; set; }
            public DateTime Expiry { get; set; }
        }

        private class Employee
        {
            public string Id { get; set; }
            public Option<WorkPermit> WorkPermit { get; set; }
            
        }
    }
}
