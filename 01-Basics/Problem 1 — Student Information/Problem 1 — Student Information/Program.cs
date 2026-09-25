
Console.Write("Enter the student's name:");
string name = Console.ReadLine();
Console.Write("Enter the student's age:");
int age = int.Parse(Console.ReadLine());
Console.Write("Enter the student's grade:");
string grade = Console.ReadLine();

Console.WriteLine("Student Information");
Console.WriteLine("-------------------");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Grade: {grade}");