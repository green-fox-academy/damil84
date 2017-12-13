using System;

namespace Apples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.GetApple());
            Console.ReadLine();
        }

        public string GetApple()
        {
            return "apple";
        }
    }
}
