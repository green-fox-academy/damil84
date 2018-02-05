using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fox> foxList = new List<Fox>()
            {
                new Fox("Don Kartács", "asbest", "green"),
                new Fox("kisvuk", "badcat", "red"),
                new Fox("Kara", "please", "red"),
                new Fox("Foxi Maxi", "asbest", "green"),
                new Fox("Red Skull", "asbest", "red"),
                new Fox("Elizabeth", "please", "yellow"),
                new Fox("Róka Rudi", "asbest", "green"),
                new Fox("Naruto", "please", "green"),
                new Fox("Foxy Lady", "badcat", "green")
            };

            Console.WriteLine("Here are the greem foxes names:");
            foxList.Where(fox => fox.Color == "green").ToList().ForEach(fox => Console.WriteLine(fox.Name));

            Console.WriteLine();
            Console.WriteLine("And here are the green foxes of the asbest corsac:");

            foxList.Where(fox => fox.Color == "green" && fox.Type == "asbest").ToList().ForEach(fox => Console.WriteLine(fox.Name));

            Console.ReadLine();
        }
    }
}