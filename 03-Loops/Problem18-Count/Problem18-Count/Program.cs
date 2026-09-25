Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 0;
int n = number;

while(n != 0)
{
    n /= 10;
    count++;
}

Console.WriteLine("Number of digits in the number: " + count);