class BankAccount
{
    private double _balance;

    public double Balance => _balance;

    public BankAccount(double initialBalance)
    {
        if (initialBalance >= 0)
        {
            _balance = initialBalance;
        }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            _balance += amount;
            Console.WriteLine($"Deposited: {amount}. New balance: {_balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= _balance)
        {
            _balance -= amount;
            Console.WriteLine($"Withdrew: {amount}. New balance: {_balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(30000);

        Console.WriteLine($"Initial Balance: {account.Balance}");

        account.Deposit(1000);
        account.Withdraw(500);
    }
}