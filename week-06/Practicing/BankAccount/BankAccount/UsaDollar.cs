namespace BankAccounts
{
    // Create a constructor that accepts the value.
    // The code should be "USD"
    // and the central bank name should be "Federal Reserve System"
    class UsaDollar : Currency
    {
        private const string Code = "USD";
        private const string CentralBankName = "Federal Reserve System";

        public UsaDollar(int value) : base (Code, CentralBankName)
        {
            Value = value;
        }
    }
}