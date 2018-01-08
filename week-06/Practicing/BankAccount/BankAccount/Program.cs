using System;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Currency class.

            // Create a UsaDollar class that inherits from the Currency.
            
            // Create a HungarianForint class that inherits from the Currency.

            // Create a BankAccount class.

            // Create a withdraw method with two parameters: a pin code and an amount.
            // It should check if the given pin is correct (equals with the original pin)
            // and the Currency's value is more than the amount parameter.
            // If so, subtract the amount from the Currency's value and return with the amount.
            // Otherwise don't modify the Currency's value and return with 0.

            // Create a Bank class which can store BankAccounts.
           
            // For example:

            Currency janeCash = new UsaDollar(1500);

            var janeAcc = new BankAccount("Jane", "1234", janeCash);
            janeAcc.Deposit(500);

            int janeWithdraw = janeAcc.Withdraw("1111", 500);
            Console.WriteLine("janeWithdraw = " + janeWithdraw)
            // janeWithdraw = 0

            janeWithdraw = janeAcc.Withdraw("1234", 500);
            Console.WriteLine("janeWithdraw = " + janeWithdraw)
            // janeWithdraw = 500

            janeWithdraw = janeAcc.Withdraw("1234", 2000);
            Console.WriteLine("janeWithdraw = " + janeWithdraw)
            // janeWithdraw = 0

            Currency johnnyCash = new HungarianForint(500);

            var myBank = new Bank();
            myBank.CreateAccount(janeAcc);
            myBank.CreateAccount(new BankAccount("Johnny", "1993", johnnyCash));

            int allMoney = myBank.GetAllMoney();
            Console.WriteLine("allMoney = " + allMoney)
            // allMoney = 2000

            Console.ReadLine();
        }
    }
}