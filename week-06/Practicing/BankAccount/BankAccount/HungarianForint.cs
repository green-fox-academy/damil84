namespace BankAccounts
{
    // Create a constructor that accepts the value.
    // The code should be "HUF"
    // and the central bank name should be "Hungarian National Bank
    internal class HungarianForint : Currency
    {
        private int v;

        public HungarianForint(int v)
        {
            this.v = v;
        }
    }
}