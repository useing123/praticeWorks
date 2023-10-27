using System;

class Client
{
    public BankAccount Account { get; set; }
    public CreditCard CreditCard { get; set; }
}

class BankAccount
{
    public decimal Balance { get; set; }

    public void PayOrder(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Paid ${amount} for the order.");
        }
        else
        {
            Console.WriteLine("Insufficient balance. Payment failed.");
        }
    }

    public void TransferFunds(decimal amount, BankAccount recipient)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            recipient.Balance += amount;
            Console.WriteLine($"Transferred ${amount} to the recipient.");
        }
        else
        {
            Console.WriteLine("Insufficient balance. Transfer failed.");
        }
    }
}

class CreditCard
{
    public bool IsBlocked { get; set; }

    public void BlockCard()
    {
        IsBlocked = true;
        Console.WriteLine("Credit card is blocked.");
    }
}

class PaymentSystem
{
    public void ProcessPayment(Client client, decimal amount, BankAccount recipientAccount)
    {
        if (client.CreditCard.IsBlocked)
        {
            Console.WriteLine("Payment failed. The credit card is blocked.");
        }
        else
        {
            client.Account.PayOrder(amount, recipientAccount);
        }
    }

    public void BlockCard(CreditCard creditCard)
    {
        creditCard.BlockCard();
    }

    public void CancelAccount(BankAccount account)
    {
        account.Balance = 0;
        Console.WriteLine("Account canceled. Balance set to $0.");
    }
}

class Program
{
    static void Main()
    {
        // Create and initialize client, bank accounts, and credit cards
        Client client = new Client
        {
            Account = new BankAccount { Balance = 1000.0m },
            CreditCard = new CreditCard { IsBlocked = false }
        };

        BankAccount recipientAccount = new BankAccount { Balance = 500.0m };

        PaymentSystem paymentSystem = new PaymentSystem();

        // Process a payment
        decimal paymentAmount = 200.0m;
        paymentSystem.ProcessPayment(client, paymentAmount, recipientAccount);

        Console.WriteLine("Client's Updated Account Balance: $" + client.Account.Balance);
        Console.WriteLine("Recipient's Updated Account Balance: $" + recipientAccount.Balance);
    }
}
