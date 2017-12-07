using System;

namespace Exercise4_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool yesOrNo = true;
            do
            {
                Console.WriteLine("Please give the base number of your choosing >>>");
                double inputBase = double.Parse(Console.ReadLine());

                Console.WriteLine("Now Please give the power of your choosing >>>");

                int inputPower = int.Parse(Console.ReadLine());
                double result = Power(inputBase, inputPower);

                Console.WriteLine("The result is: " + result);
                Console.WriteLine();
                Console.WriteLine();


                Console.WriteLine("Would you like to do another calculation? y/n");

                if (Console.ReadKey(true).KeyChar == 'n')
                    { yesOrNo = false;
                    break; }
            }
            while (yesOrNo);

        }

        static public double Power(double inputBase, int inputPower)
        {
            if (inputPower == 0)
            {
                return 1.0;
            }
            else
            {
                return inputBase * Power(inputBase, inputPower - 1);

            } 
        }
    }
}
