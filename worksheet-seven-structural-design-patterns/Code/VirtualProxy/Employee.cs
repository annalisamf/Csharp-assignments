namespace VirtualProxy
{
    public sealed class Employee

    {
        private string EmployeeName { get; }
        private decimal EmployeeSalary { get; }
        private string EmployeeDesignation { get; }

        public Employee(string employeeName, decimal employeeSalary, string employeeDesignation)
        {
            EmployeeName = employeeName;
            EmployeeSalary = employeeSalary;
            EmployeeDesignation = employeeDesignation;
        }

        public override string ToString()
        {
            return
                $"Employee Name: {EmployeeName}, EmployeeDesignation: {EmployeeDesignation}, Employee Salary: {EmployeeSalary}";
        }
    }
}