using System;

namespace exercise5
{
    class Functions
    {
        public void Calculations()
        {
            Console.WriteLine("Please type the first number >>");
            int firstNumber;
            while (!int.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("This is not an integer number, please try to type first number again >>");
            }

            Console.WriteLine("Please now type the second number >>");
            int secondNumber;
            while (!int.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("This is not an integer number, please try to type second number again >>");
            }

            Console.WriteLine();
            Console.WriteLine("The result of adding is: " + (secondNumber + firstNumber));
            Console.WriteLine("The result of substraction is: " + (secondNumber - firstNumber));
            Console.WriteLine("The result of multiplication is: " + (firstNumber * secondNumber));
            Console.WriteLine("The result of dividation as a decimal fraction is: " + (firstNumber / (decimal)secondNumber));
            Console.WriteLine("The result of dividation integer part is: " + (firstNumber / secondNumber));
            Console.WriteLine("The result of dividation reminder is: " + (firstNumber % secondNumber));
        }
    }
}
