Console.Write("Enter the marks obtained in the subject: ");
double marks = Convert.ToDouble(Console.ReadLine());

if(marks >= 80 && marks <= 100)
{
    Console.WriteLine("Grade: A+");
}
else if (marks >= 70 && marks < 80)
{
    Console.WriteLine("Grade: A");
}
else if (marks >= 60 && marks < 70)
{
    Console.WriteLine("Grade: B");
}
else if (marks >= 50 && marks < 60)
{
    Console.WriteLine("Grade: C");
}
else if (marks >= 40 && marks < 50)
{
    Console.WriteLine("Grade: D");
}
else if (marks >= 0 && marks < 40)
{
    Console.WriteLine("Grade: F");
}
else
{
    Console.WriteLine("Invalid marks entered.");
}