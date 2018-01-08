using System;

namespace BankAccounts
{
    // Create a deposit method which check if the given parameter is positive
    // then adds the parameter to the Currency's value field.
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
    }
}