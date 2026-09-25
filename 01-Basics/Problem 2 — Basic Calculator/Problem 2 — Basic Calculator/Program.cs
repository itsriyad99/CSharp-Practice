Console.Write("Enter 1st number: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter 2nd number: ");
int b = int.Parse(Console.ReadLine());

int addition = a + b;
int subtraction = a - b;
int multiplication = a * b;
int division = a/b;
int remainder = a % b;

Console.WriteLine($"Addition: {addition}");
Console.WriteLine($"Subtraction: {subtraction}");
Console.WriteLine($"Multiplication: {multiplication}");
Console.WriteLine($"Division: {division}");
Console.WriteLine($"Remainder: {remainder}");
