using System.Collections.Generic;
using System.Linq;

namespace BankAccounts
{
    internal class Bank
    {
        private List<BankAccount> AccountList = new List<BankAccount>();

        public void CreateAccount(BankAccount bankAccount)
        {
            AccountList.Add(bankAccount);
        }

        public int GetAllMoney()
        {
            return AccountList.Sum(a => a.Currency.Value);
        }
    }
}