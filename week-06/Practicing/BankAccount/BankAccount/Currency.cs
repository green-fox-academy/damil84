using System;

namespace BankAccounts
{
    public class Currency
    { 
        public string CentralBankName { get; set; }
        public string Code { get; set; }
        public int Value { get; set; }

        public Currency(string code, string centralBankName)
        {
            Code = code;
            CentralBankName = centralBankName;
        }
    }
}