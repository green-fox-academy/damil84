namespace BankAccounts
{
    // It should have a name, a pin code and a Currency field.
    // Create a constructor for setting those values.
    internal class BankAccount
    {
        private string v1;
        private string v2;
        private Currency janeCash;

        public BankAccount(string v1, string v2, Currency janeCash)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.janeCash = janeCash;
        }
    }
}