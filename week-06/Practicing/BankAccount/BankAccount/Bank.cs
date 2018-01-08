using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    // It should have a createAccount method with a BankAccount as an input parameter.
    // It should have a getAllMoney method, which returns the sum of
    // the accounts' money (sum of Currency values regardless of the Currency type).
    internal class Bank
    {
        private List<BankAccount> AccountList = new List<BankAccount>();

        public void CreateAccount(BankAccount bankAccount)
        {
            AccountList.Add(bankAccount);
        }

        public int GetAllMoney()
        {
            int allMoney = 0;
            foreach (BankAccount bankAccount in AccountList)
                allMoney += bankAccount.Currency.Value;
            return allMoney;

           
        }
    }
}