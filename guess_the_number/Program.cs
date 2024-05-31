using System;
using System.Threading;

//teste maroto

namespace ConsoleGames
{
    class Program
    {
        //arrumar essa interface que está pessima
        static void Main()
        {
            Console.Title = "Lucky games";
            string userGameChoice = string.Empty;
            bool stillChoosing = true;
            int clearenceTimer = 1000;
            string userName = string.Empty;

            Console.Write("Welcome! Before we start, please enter your nickname: ");

            while (string.IsNullOrEmpty(userName = Console.ReadLine()) || userName.Length > 25 || userName.Length <= 3)
            {
                Console.Write("We need a valid name! Please, try again: ");
            }

            while (stillChoosing)
            {
                Console.Clear();

                Console.Write($"Welcome to the games table {userName}! We hope you enjoy your time here. . .\n");

                Console.WriteLine("\nWe have these console games for now: \n");
                Console.WriteLine("1 - GuessTheNumber");
                Console.WriteLine("2 - Coin-Flip");
                Console.WriteLine("3 - Fizzbuzz");
                Console.WriteLine("4 - RollTheDices");

                Console.Write("Which game do you want to play? [type E to close the console]: ");
                userGameChoice = Console.ReadLine().ToUpper();

                //super zuado essas instancias vazias, ver um jeito que faça mais sentido em relação a isso
                if (userGameChoice == "1")
                {
                    GuessTheNumber guessing_game = new GuessTheNumber();
                    guessing_game.GuessTheNumberGame();
                }
                else if (userGameChoice == "2")
                {
                    CoinFlip flip_game = new CoinFlip();
                    flip_game.CoinFlipGame();
                }
                else if (userGameChoice == "3")
                {
                    Fizzbuzz fizzbuzz = new Fizzbuzz();
                    fizzbuzz.FizzBuzz();
                }
                else if (userGameChoice == "4")
                {
                    RollTheDices rollthedices = new RollTheDices();
                    rollthedices.RollTheDicesGame();
                }
                else if (userGameChoice == "E")
                {
                    Console.WriteLine("Press any key to close the program. . .");
                    Console.ReadKey(true);
                    stillChoosing = false;
                }
                else
                {
                    Console.WriteLine("Wrong parameter, try again.");
                    Thread.Sleep(clearenceTimer);
                }
            }
        }
    }
}







