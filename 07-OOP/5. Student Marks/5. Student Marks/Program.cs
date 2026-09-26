using System.Reflection.Metadata;

class Student
{
    private double Marks;

    public void SetMarks(double marks)
    {
        if (marks < 0 || marks > 100)
        {
            Console.WriteLine("Marks should be between 0 and 100.");
        }
        else
        {
            Marks = marks;
        }
    }

    public double GetMarks()
    {
        return Marks;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.SetMarks(85);
        Console.WriteLine("Student Marks: " + student.GetMarks());

        Student student1 = new Student();
        student1.SetMarks(105); // Invalid marks
    }
}