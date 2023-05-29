namespace FluentInterface;

internal class FluentEmployee
{
    private Employee _employee = new Employee();

    public FluentEmployee EmployeeName(string name)
    {
        _employee.FullName = name;
        return this;
    }

    public FluentEmployee EmployeeDateOfBirth(string  dateOfBirth)
    {
        _employee.DateOfBirth = Convert.ToDateTime(dateOfBirth);
        return this;
    }

    public FluentEmployee EmployeeDesignation(string designation)
    {
        _employee.Designation = designation;
        return this;
    }

    public FluentEmployee EmployeeAddress(string address)
    {
        _employee.Address = address;
        return this;
    }

    public FluentEmployee EmployeeChildrenCount(int childrenNumber)
    {
        _employee.NumberOfChildren = childrenNumber;
        return this;
    }

    public void PrintEmployeeDetails()
    {
        Console.WriteLine($"Employee name: {_employee.FullName}\nDate of Birth: ${_employee.DateOfBirth.ToShortDateString()}\nDesignation: {_employee.Designation}\n Address: {_employee.Address}\nChildren: {_employee.NumberOfChildren}");
    }
}
