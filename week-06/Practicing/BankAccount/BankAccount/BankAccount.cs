using System;

namespace BankAccounts
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string PinCode { get; set; }
        public Currency Currency { get; set; }

        public BankAccount(string name, string pinCode, Currency currency)
        {
            Name = name;
            PinCode = pinCode;
            Currency = currency;
        }

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                Currency.Value += amount;
            }
        }

        public int Withdraw(string pinCode, int amount)
        {
            if (PinCode == pinCode && Currency.Value >= amount)
            {
                return (Currency.Value -= amount);
            }
            else return Currency.Value;
        }
    }
}