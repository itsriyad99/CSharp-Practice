class Employee_Salary
{
    private double Salary;
    
    public void SetSalary(double salary)
    {
        if(salary < 0)
        {
            throw new ArgumentException("Salary cannot be negative.");
        }
        else
        {
            Salary = salary;
        }
    }

    public double IncreaseSalary(double percentage)
    {
        if (percentage < 0)
        {
            throw new ArgumentException("Percentage cannot be negative.");
        }
        else
        {
            Salary += Salary * (percentage / 100);
            return Salary;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee_Salary employee = new Employee_Salary();
        
        try
        {
            employee.SetSalary(50000);
            Console.WriteLine("Initial Salary: " + employee.IncreaseSalary(0) + " BDT");
            
            double newSalary = employee.IncreaseSalary(10);
            Console.WriteLine("New Salary after 10% increase: " + newSalary + " BDT");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
