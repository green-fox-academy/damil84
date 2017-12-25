using System;

namespace exercise5
{
    class Functions : Program
    {
        public void Calculations()
        {
            Console.WriteLine("Please type the first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please now type the second number");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The result of adding is: " + (firstNumber + secondNumber));
            Console.WriteLine("The result of substraction is: " + (secondNumber - firstNumber));
            Console.WriteLine("The result of multiplication is: " + (secondNumber * firstNumber));
            Console.WriteLine("The result of dividation as a decimal fraction is: " + (firstNumber / (decimal)secondNumber));
            Console.WriteLine("The result of dividation integer part is: " + (firstNumber / secondNumber));
            Console.WriteLine("The result of dividation reminder is: " + (firstNumber % secondNumber));

        }
    }
}
