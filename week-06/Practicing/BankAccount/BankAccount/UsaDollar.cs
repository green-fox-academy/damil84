namespace BankAccounts
{
    // Create a constructor that accepts the value.
    // The code should be "USD"
    // and the central bank name should be "Federal Reserve System"
    internal class UsaDollar : Currency
    {
        private int v;

        public UsaDollar(int v)
        {
            this.v = v;
        }
    }
}