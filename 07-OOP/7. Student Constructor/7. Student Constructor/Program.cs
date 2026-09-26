class Student
{
    private string name = "";
    private int age;
    private string department = "";

    public Student(string name, int age, string department)
    {
        this.name = name;
        this.age = age;
        this.department = department;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Department: {department}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Riyad", 23, "Computer Science");

        student.ShowInfo();
    }
}