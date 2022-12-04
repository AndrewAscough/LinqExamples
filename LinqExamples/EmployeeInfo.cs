namespace LinqExamples
{
    public class EmployeeInfo
    {
        public static IEnumerable<Employee> EmployeesWithSalaryGreaterThan100K(IEnumerable<Employee> employees)
        {
            return (from employee in employees
                where employee.Salary > 100000
                select employee
            );
        }

        public static double AverageConsultantSalaryInBrisbane(IEnumerable<Employee> employees)
        {
            return EmployeeInfoHelper.AverageSalary((from employee in employees
                where employee.City == "Brisbane" && employee.Level == "Consultant"
                select employee
            ));
        }
    }
}