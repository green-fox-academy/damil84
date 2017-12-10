using System;

namespace Exercise4_Power
{
    class Program
    {
        public static bool yesOrNo = true;

        static void Main(string[] args)
        {
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
                {
                    yesOrNo = false;
                }

                else if (Console.ReadKey(true).KeyChar == 'y')
                {
                    yesOrNo = true;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Please type only 'y' for yes or 'n' for no");
                    }
                    while (Console.ReadKey(true).KeyChar != 'n' && Console.ReadKey(true).KeyChar != 'y');
                    if (Console.ReadKey(true).KeyChar == 'n')
                    {
                        yesOrNo = false;
                    }

                }
            }
            while (yesOrNo == true);
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
