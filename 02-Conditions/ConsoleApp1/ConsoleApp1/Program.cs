Console.Write("Enter 1st number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2nd number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("The 1st number is greater than the 2nd number.");

}
else if (a < b)
{
    Console.WriteLine("The 1st number is less than the 2nd number.");
}
else
{
    Console.WriteLine("Both numbers are equal.");
}