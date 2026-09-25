Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

int n = number;
int reverse = 0;

while (n != 0)
{
    int rem = n % 10;
    reverse = reverse * 10 + rem;
    n =n/10;
}

if(number == reverse)
{
    Console.WriteLine($"{number} is a palindrome.");
}
else
{
    Console.WriteLine($"{number} is not a palindrome.");
}