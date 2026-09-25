Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a > 0)
{
    Console.WriteLine("The number is positive.");
}
else if (a < 0)
{
    Console.WriteLine("The number is negative.");
}
else
{
    Console.WriteLine("The number is zero.");
}