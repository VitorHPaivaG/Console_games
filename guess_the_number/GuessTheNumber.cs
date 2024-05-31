using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGames
{
    internal class GuessTheNumber
    {
        public void GuessTheNumberGame()
        {
            Random random = new Random();
            bool stillPlaying = true;
            int userNumberDelimiter;

            Console.Write("Please enter a number for the limiter (Example: 1 to X [X = 20] ): ");

            while (!int.TryParse(Console.ReadLine(), out userNumberDelimiter) || (userNumberDelimiter <= 0))
            {
                Console.Clear();
                Console.Write("The number delimiter must not be negative or equals to 0\n");
                Console.Write("Try again, enter the number delimiter: ");
            }

            Console.Write("Find the correct number: ");

            int correctGuess = random.Next(1, userNumberDelimiter);

            while (stillPlaying)
            {
                int userGuess = Convert.ToInt32(Console.ReadLine());//tryparse
                if (userGuess == correctGuess)
                {
                    Console.WriteLine($"Congrats, you´ve find the correct number: {correctGuess}");
                    Console.ReadKey();
                    stillPlaying = false;
                }
                else
                {
                    Console.Write("Incorrect guess, try again: ");
                }
            }
        }
    }
}
