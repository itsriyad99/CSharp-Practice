Console.Write("Input an integer: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 2 == 0)
{
    Console.WriteLine($"{a} is an even number.");
}
else
{
    Console.WriteLine($"{a} is an odd number.");
}