namespace Bankomat.Client
{
    public class Client
    {
        public string CardNumber { get; private set; }
        private string Password;
        private Account Account;

        public Client(string cardNumber, string password, Account account)
        {
            CardNumber = cardNumber;
            Password = password;
            Account = account;
        }

        public bool VerifyPassword(string inputPassword)
        {
            return Password == inputPassword;
        }

        public double GetBalance()
        {
            return Account.Balance;
        }

        public void Deposit(double amount)
        {
            Account.Deposit(amount);
        }

        public bool Withdraw(double amount)
        {
            return Account.Withdraw(amount);
        }
    }
}
