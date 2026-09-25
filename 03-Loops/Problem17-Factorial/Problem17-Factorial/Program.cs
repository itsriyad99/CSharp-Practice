Console.Write("Enter a number to calculate its factorial: ");
int number = int.Parse(Console.ReadLine());

int fact = 1;
for(int i=1;i<number;i++)
{
    fact = fact*i;
}
Console.WriteLine($"The factorial of {number} is: {fact}");