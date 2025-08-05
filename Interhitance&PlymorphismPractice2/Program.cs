Employee[] employees = new Employee[]
{
    new FullTimeEmployee("Alice", 5000),
    new PartTimeEmployee("Bob", 20, 80),
    new Intern("Charlie")

};
foreach (Employee employee in employees)
{
    employee.CaculateSalary();
}

class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }
    public virtual void CaculateSalary()
    {
        Console.WriteLine($"{Name}: Salary calculation is not fedined");
    }
}

class FullTimeEmployee : Employee
{
    private double _fixedSalary;
    public FullTimeEmployee(string name, double fixedSalary) : base(name)
    {
        _fixedSalary = fixedSalary;
    }

    public override void CaculateSalary()
    {
        Console.WriteLine($"{Name}: Full-time salary is {_fixedSalary}");
    }
}

class PartTimeEmployee : Employee
{
    private double _hourlyRate;
    private int _hoursWorked;

    public PartTimeEmployee(string name, double hourlyRate, int hoursWorked) : base(name)
    {
        _hourlyRate = hourlyRate;
        _hoursWorked = hoursWorked;
    }

    public override void CaculateSalary()
    {
        double salary = _hourlyRate * _hoursWorked;
        Console.WriteLine($"{Name}: Part-time salary is {salary}");
    }
}

class Intern : Employee
{
    public Intern(string name) : base(name)
    {

    }

    public override void CaculateSalary()
    {
        Console.WriteLine($"{Name}: Intern do not recevie a salary");
    }
}