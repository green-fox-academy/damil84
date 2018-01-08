namespace BankAccounts
{
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