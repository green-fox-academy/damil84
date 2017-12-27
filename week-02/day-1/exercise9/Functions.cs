using System;
using System.Collections.Generic;
using System.Text;

namespace exercise9
{
    class Functions
    {
        public void BMIcalculation()
        {
            Console.WriteLine("Please tell me your name >>");
            string name = Console.ReadLine(); 

            Console.WriteLine("Please type in your mass in kilograms >>");
            double massInKg;
            while (!double.TryParse(Console.ReadLine(), out massInKg))
            {
                Console.WriteLine("This is not a number, or you used '.' insted of ',' for fraction. Please try to type in numbers again >>");
            }

            Console.WriteLine("Please type in your height in meter >>");
            double heightInM;
            while (!double.TryParse(Console.ReadLine(), out heightInM))
            {
                Console.WriteLine("This is not a number, or you used '.' insted of ',' for fraction. Please try to type in numbers again >>");
            }

            double bmi = massInKg / (heightInM * heightInM);
            Console.WriteLine("Dear {0}, your BMI value is {1} ", name, bmi);
        }

    }
}
