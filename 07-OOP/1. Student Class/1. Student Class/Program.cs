class Student 
{
    public string Name="";
    public int Age;
    public string Department="";
    public double CGPA;

}
class Program
{

    static void Main(string[] args)
    {

        Student S1 = new Student();
        Student S2 = new Student();

        S1.Name = "Md. Riyad";
        S1.Age = 23;
        S1.Department = "CSE";
        S1.CGPA = 3.85;

        S2.Name = "Wayech Kuruni";
        S2.Age = 22;
        S2.Department = "EEE";
        S2.CGPA = 3.75;

        Console.WriteLine("Student 1 Information:");
        Console.WriteLine("Name: " + S1.Name);
        Console.WriteLine("Age: " + S1.Age);
        Console.WriteLine("Department: " + S1.Department);
        Console.WriteLine("CGPA: " + S1.CGPA);

        Console.WriteLine("\nStudent 2 Information:");
        Console.WriteLine("Name: " + S2.Name);
        Console.WriteLine("Age: " + S2.Age);
        Console.WriteLine("Department: " + S2.Department);
        Console.WriteLine("CGPA: " + S2.CGPA);
    }
}
