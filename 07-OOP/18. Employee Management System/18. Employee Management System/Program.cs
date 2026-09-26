abstract class Employee
{
    public int Id;
    public string Name = "";

    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public abstract void calculateSalary();
}

class FullTimeEmployee : Employee
{
    public int Salary;

    public FullTimeEmployee(int id, string name, int salary)
        : base(id, name)
    {
        Salary = salary;
    }

    public override void calculateSalary()
    {
        Console.WriteLine($"Full Time Employee {Name} has a salary of {Salary}");
    }
}

class PartTimeEmployee : Employee
{
    public int HourlyRate;
    public int HoursWorked;

    public PartTimeEmployee(int id, string name, int hourlyRate, int hoursWorked)
        : base(id, name)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override void calculateSalary()
    {
        Console.WriteLine(
            $"Part Time Employee {Name} has a salary of {HourlyRate * HoursWorked}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new FullTimeEmployee(1, "Riyad", 50000);
        employee1.calculateSalary();

        Employee employee2 = new PartTimeEmployee(2, "Wayech", 20, 40);
        employee2.calculateSalary();
    }
}