using BankOfSimba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.ViewModels
{
    public class AccountsViewModel
    {
        public List<BankAccount> AccountList { get; set; } = new List<BankAccount>();

        public AccountsViewModel()
        {
            AddCharacters();
        }

        private void AddCharacters()
        {
            AccountList.Add(new BankAccount("Simba", 2000.00, "zebra", "Lion"));
            AccountList.Add(new BankAccount("Rafiki", 500.00, "banana", "Baboon"));
            AccountList.Add(new BankAccount("Nala", 3500.00, "zebra", "Lion"));
            AccountList.Add(new BankAccount("Zazu", 20000.00, "insect", "Hornbill"));
            AccountList.Add(new BankAccount("Timon", 10000.00, "insect", "Merkaat"));
            AccountList.Add(new BankAccount("Pumbaa", 8000.00, "insect", "Warthog"));
            AccountList.Add(new BankAccount("Scar", 2000.00, "zebra", "Lion"));
            AccountList.Add(new BankAccount("Mufasa", 0.00, "zebra", "Lion"));
            AccountList.Add(new BankAccount("Shenzi", 500.00, "zebra", "Spotted Hyena"));
            AccountList.Add(new BankAccount("Banzai", 50.00, "zebra", "Spotted Hyena"));
            AccountList.Add(new BankAccount("Ed", 0.50, "zebra", "Spotted Hyena"));
        }
    }
}