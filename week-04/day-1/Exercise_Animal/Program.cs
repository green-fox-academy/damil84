using System;

namespace Exercise_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            var wolf = new Animal();
            Console.WriteLine("The wolf's hunger is: " + wolf.GetHungerStatus() + ", and the wolf's thirst is: " + wolf.GetThirstStatus());
            wolf.Eat();
            wolf.Drink();
            wolf.Play();
            wolf.Drink();
            wolf.Play();
            wolf.Play();
            wolf.Play();

            Console.WriteLine("The wolf's hunger is: " + wolf.GetHungerStatus() +", and the wolf's thirst is: " + wolf.GetThirstStatus());
            Console.ReadLine();
        }
    }
}
