interface IPayment
{
    void Pay(double amount);
}

class BkashPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using Bkash.");
    }
}

class CardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using Card.");
    }
}

class CashPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using Cash.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IPayment paymentMethod;
        Console.WriteLine("Select payment method: 1. Bkash 2. Card 3. Cash");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                paymentMethod = new BkashPayment();
                break;
            case 2:
                paymentMethod = new CardPayment();
                break;
            case 3:
                paymentMethod = new CashPayment();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }
        Console.Write("Enter amount to pay: ");
        double amount = Convert.ToDouble(Console.ReadLine());
        paymentMethod.Pay(amount);
    }
}