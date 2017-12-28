using System;

namespace exercise9
{
    class Program
    {
        public static bool anotherCalculation = true; 
        static void Main(string[] args)
        {
            Functions bmi = new Functions();
            do
            {
                bmi.BMIcalculation();
                Console.WriteLine();
                Console.WriteLine("Would you like to do another calculation? y/n");
                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    anotherCalculation = false;
                }
                else if (Console.ReadKey(true).KeyChar == 'y')
                {
                    Console.WriteLine();
                    anotherCalculation = true;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Please try to type only 'y' for yes or 'n' for no.");
                    }
                    while (Console.ReadKey(true).KeyChar != 'n' && Console.ReadKey(true).KeyChar != 'y');
                    if (Console.ReadKey(true).KeyChar == 'n')
                    {
                        anotherCalculation = false;
                    }
                }
            }
            while (anotherCalculation == true);
        }
    }
}
