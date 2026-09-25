
Console.Write("Enter the mark of Bangla: ");
double bangla = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the mark of English: ");
double english = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the mark of Math: ");
double math = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the mark of Physics: ");
double physics = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the mark of ICT: ");
double ict = Convert.ToDouble(Console.ReadLine());

double totalMarks = bangla + english + math + physics + ict;
double averageMarks = totalMarks / 5;

Console.WriteLine("Total Marks: " + totalMarks);
Console.WriteLine("Average Marks: " + averageMarks);