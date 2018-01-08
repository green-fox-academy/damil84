using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    class Currency
    { // It should have a code, a central bank name and a value field.
      // Create a constructor for setting those values.
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