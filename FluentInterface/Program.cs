using FluentInterface;

internal class Program
{
    internal static void Main(string[] args)
    {
        var employee = new FluentEmployee();
        employee.EmployeeName("John")
            .EmployeeDateOfBirth("10/05/1990")
            .EmployeeAddress("United States of America")
            .EmployeeDesignation("Manager")
            .EmployeeChildrenCount(3);

        employee.PrintEmployeeDetails();
    }
}