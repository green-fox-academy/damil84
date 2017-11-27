using System;

namespace exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            int remainingSeconds = (24 * 60 * 60) - (currentSeconds + currentMinutes * 60 + currentHours * 60 * 60);
            Console.WriteLine("The remaining time from the day is: " + remainingSeconds + " seconds.");
            Console.ReadLine();

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented bt the variables
        }
    }
}
