namespace GreetCounterREST.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }

        public Greeting(string userName, int userCounter)
        {
            Id = userCounter;
            Content = "Hello-bello-jello, " + userName;
        }
    }
}