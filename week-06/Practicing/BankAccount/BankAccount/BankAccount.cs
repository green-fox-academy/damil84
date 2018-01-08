using System;

namespace BankAccounts
{
    class BankAccount
    {
        private string Name { get; set; }
        private string PinCode { get; set; }
        private Currency Currency { get; set; }

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

        // Create a withdraw method with two parameters: a pin code and an amount.
        // It should check if the given pin is correct (equals with the original pin)
        // and the Currency's value is more than the amount parameter.
        // If so, subtract the amount from the Currency's value and return with the amount.
        // Otherwise don't modify the Currency's value and return with 0.
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