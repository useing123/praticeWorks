using System;

namespace Bankomat.Bank
{
    public class Account
    {
        public int AccountNumber { get; private set; }
        public double Balance { get; private set; }
        private string Password;

        public Account(int accountNumber, string password)
        {
            AccountNumber = accountNumber;
            Password = password;
            Balance = 0;
        }

        public bool VerifyPassword(string inputPassword)
        {
            return Password == inputPassword;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}

