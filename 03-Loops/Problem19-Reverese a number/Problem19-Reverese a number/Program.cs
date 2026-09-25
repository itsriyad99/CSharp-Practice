Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int n = number;
int reverse = 0;

while(n != 0)
{
    int rem = n % 10;
    reverse = reverse * 10 + rem;
    n = n / 10;
}

Console.WriteLine($"The reverse number is: {reverse}");