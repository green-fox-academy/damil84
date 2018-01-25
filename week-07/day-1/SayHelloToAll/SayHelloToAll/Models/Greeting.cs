namespace SayHelloToAll.Models
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

        //public Greeting(int webCounter, string userName)
        //{
        //    Content = userName;
        //    Id = webCounter;
        //}

        public Greeting()
        {
        }
    }
}