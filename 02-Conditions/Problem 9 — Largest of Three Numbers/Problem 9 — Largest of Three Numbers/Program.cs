Console.Write("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a >= b && a >= c)
{
    Console.WriteLine($"The largest number is: {a}");
}
else if (b >= a && b >= c)
{
    Console.WriteLine($"The largest number is: {b}");
}
else
{
    Console.WriteLine($"The largest number is: {c}");
}