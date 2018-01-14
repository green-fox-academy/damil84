using System;
using System.Collections.Generic;

namespace Exercise_Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Animals();
            var cow = new Animals();
            var chicken = new Animals();
            var pig = new Animals();
            var cat = new Animals();

            var farm = new Farm(new List<Animals>() { dog, cow, chicken, pig, cat }, 5);

            dog.Eat();
            cow.Eat();
            dog.Play();
            dog.Play();
            dog.Play();
            cat.Play();
            cat.Play();
            cat.Play();
            cat.Play();
            pig.Eat(); pig.Eat(); pig.Eat(); pig.Eat(); pig.Eat(); pig.Eat(); pig.Eat(); pig.Eat(); pig.Eat(); pig.Eat(); pig.Eat();

            Console.WriteLine("The chicken's hunger is: " + chicken.GetHungerStatus() + ", and the chicken's thirst is: " + chicken.GetThirstStatus());
            Console.WriteLine("The cow's hunger is: " + cow.GetHungerStatus() + ", and the cow's thirst is: " + cow.GetThirstStatus());
            Console.WriteLine("The pig's hunger is: " + pig.GetHungerStatus() + ", and the pig's thirst is: " + pig.GetThirstStatus());
            Console.WriteLine("The cat's hunger is: " + cat.GetHungerStatus() + ", and the cat's thirst is: " + cat.GetThirstStatus());
            Console.WriteLine("The dog's hunger is: " + dog.GetHungerStatus() + ", and the wolf's thirst is: " + dog.GetThirstStatus());

            farm.Slaughter();
            farm.Breed();
            farm.Breed();
            farm.Breed();

            for (int i = 0;  i <farm.AnimalList.Count; i++)
            {
                Console.WriteLine(farm.AnimalList[i].HungerValue);
                Console.WriteLine(farm.AnimalList[i].ThirstValue);
            }

            Console.ReadLine();
        }
    }
}