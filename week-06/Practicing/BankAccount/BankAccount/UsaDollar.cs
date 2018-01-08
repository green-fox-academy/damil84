namespace BankAccounts
{
    public class UsaDollar : Currency
    {
        private const string Code = "USD";
        private const string CentralBankName = "Federal Reserve System";

        public UsaDollar(int value) : base (Code, CentralBankName)
        {
            Value = value;
        }
    }
}