using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello in the Zoo!");
            var reptile = new Reptile("Crocodile");
            var mammal = new Mammal("Koala");
            var bird = new Bird("Parrot");
            
            Console.WriteLine("Who want a baby?");
            Console.WriteLine(reptile.GetName() + ", " + reptile.WantChild());
            Console.WriteLine(mammal.GetName() + ", " + mammal.WantChild());
            Console.WriteLine(bird.GetName() + ", " + bird.WantChild());
            Console.ReadLine();
        }
    }
}
