namespace HelloWorldREST.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }

        public Greeting(string userName)
        {
            Id = 1;
            Content = "Hello-bello-jello, " + userName;
        }
    }
}
