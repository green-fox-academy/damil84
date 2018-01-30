namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Currency { get; set; }
        public string AnimalType { get; set; }
        public string Status { get; set; }
        public bool Affiliation { get; set; }

        public BankAccount(string name, double balance, string currency, string animalType, bool affiliation)
        {
            Name = name;
            Balance = balance;
            Currency = currency;
            AnimalType = animalType;
            Affiliation = affiliation;
        }
        public BankAccount()
        {

        }
    }
}