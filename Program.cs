using System;

class BankAccount
{
    public int AccountNumber { get; set; }
    public decimal Balance { get; private set; }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: ${amount:0.00}");
            Console.WriteLine($"New balance: ${Balance:0.00}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount. Please enter a positive value.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a BankAccount object
        BankAccount account = new BankAccount();

        // Set account number (example)
        account.AccountNumber = 123456;

        // Deposit some money
        account.Deposit(50.75m);
    }
}
