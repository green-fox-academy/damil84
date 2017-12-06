using System;

namespace guessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            Console.WriteLine("Thinking about a number, can you guess it?");
            Console.WriteLine();
            Console.Write("First please give me the range's minimum value>> ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Then please give me the range's maximum value>> ");
            int max = int.Parse(Console.ReadLine());

            Console.Write("Please choose how many lives would you have>> ");
            int lives = int.Parse(Console.ReadLine());

            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(min, max);

            Console.Write("Now, you can enter your guess >> ");
            guess = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < (lives + i); i++)
            {
                if (guess == randomNumber)
                {
                    Console.WriteLine("Bullseye!You just hit the jackpot, nice guess!!! " +
                    "The number was: {0}, and you have {1} lives left", randomNumber, lives - 1);
                    break;
                }

                else
                {
                    lives--;
                    if (guess < randomNumber && lives > 1)
                    {
                        Console.WriteLine("Your guess is to low, try again. You have {0} lives left", lives);
                        Console.Write("\nPlease enter your guess >> ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }

                    else if (guess > randomNumber && lives > 1)
                    {
                        Console.WriteLine("Your guess is to high, try again. You have {0} lives left", lives);
                        Console.Write("\nPlease enter your guess >> ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }


                    if (lives - 1 < 1)
                    {
                        Console.WriteLine("Game Over! All your lives have been used.");
                        Console.WriteLine("The number was {0}", randomNumber);
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}


