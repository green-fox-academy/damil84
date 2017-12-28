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
            if (bmi < 18.5)
            {
                Console.WriteLine("According to your BMI value, you are underweight");
            }
            else if (bmi > 18.5 && bmi < 24.9 )
            {
                Console.WriteLine("According to your BMI value, you are in normal weight");
            }
            else if (bmi > 25 && bmi < 29.9)
            {
                Console.WriteLine("According to your BMI value, you are overweight");
            }
            else if (bmi > 30 && bmi < 34.9)
            {
                Console.WriteLine("According to your BMI value, you are in obesity calss I");
            }
            else if (bmi > 35 && bmi < 39.9)
            {
                Console.WriteLine("According to your BMI value, you are in obesity calss II");
            }
            else if (bmi >= 40)
            {
                Console.WriteLine("According to your BMI value, you are in obesity calss I");
            }
        }
    }
}
