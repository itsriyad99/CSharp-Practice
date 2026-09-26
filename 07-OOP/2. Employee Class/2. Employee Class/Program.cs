class Employee
{
    public int Id;
    public string Name="";
    public double Salary;
    public string Department="";

}

class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee();
        emp1.Id = 1;
        emp1.Name = "John Doe";
        emp1.Salary = 50000;
        emp1.Department = "HR";
        Employee emp2 = new Employee();
        emp2.Id = 2;
        emp2.Name = "Jane Smith";
        emp2.Salary = 60000;
        emp2.Department = "IT";
        Employee emp3 = new Employee();
        emp3.Id = 3;
        emp3.Name = "Bob Johnson";
        emp3.Salary = 55000;
        emp3.Department = "Finance";

        double highest_Salary;

        if(emp1.Salary > emp2.Salary && emp1.Salary > emp3.Salary)
        {
            highest_Salary = emp1.Salary;
        }
        else if (emp2.Salary > emp1.Salary && emp2.Salary > emp3.Salary)
        {
            highest_Salary = emp2.Salary;
        }
        else
        {
            highest_Salary = emp3.Salary;
        }
        Console.WriteLine($"Employee 1: \nId={emp1.Id},\nName={emp1.Name}, \nSalary={emp1.Salary}, \nDepartment={emp1.Department}");
        Console.WriteLine($"\nEmployee 2: \nId={emp2.Id},\nName={emp2.Name}, \nSalary={emp2.Salary}, \nDepartment={emp2.Department}");
        Console.WriteLine($"\nEmployee 3: \nId={emp3.Id},\nName={emp3.Name}, \nSalary={emp3.Salary}, \nDepartment={emp3.Department}");
        Console.WriteLine($"\nHighest Salary: {highest_Salary}");
    }
}