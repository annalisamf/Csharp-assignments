using System.Collections.Generic;

namespace VirtualProxy
{
    public class ContactsImpl : IContacts
    {
        private readonly IList<Employee> _employeeList = new List<Employee>();

        public IList<Employee> Employees()
        {
            _employeeList.Add(new Employee("Employee A", 2565.55m, "SE"));
            _employeeList.Add(new Employee("Employee B", 22574.00m, "Manager"));
            _employeeList.Add(new Employee("Employee C", 3256.77m, "SSE"));
            _employeeList.Add(new Employee("Employee D", 4875.54m, "SSE"));
            _employeeList.Add(new Employee("Employee E", 2847.01m, "SE"));
            return _employeeList;
        }
    }
}