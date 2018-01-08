namespace BankAccounts
{
    // Create a constructor that accepts the value.
    // The code should be "HUF"
    // and the central bank name should be "Hungarian National Bank
    class HungarianForint : Currency
    {
        private const string Code = "HUF";
        private const string CentralBankName = "Hungarian National Bank";

        public HungarianForint(int value) : base (Code, CentralBankName)
        {
            Value =value;
        }
    }
}