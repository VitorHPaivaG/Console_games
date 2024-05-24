using System;


//colocar um sistema de billboard, e sempre que o jogo acabar, retorne um placarScore var direto da função, pra ser
//adicionado na main tipo assim: static int GuessTheNumber() /return placarScore;
//colocar nome de usuario/s e fazer como se fosse uma grande central de minijogos single or multiplayer local

namespace guess_the_number
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Lucky games";
            string userGameChoice;

            Console.WriteLine("We have these console games for now: ");
            Console.WriteLine("1 - GuessTheNumber");
            Console.WriteLine("2 - Coin-Flip");
            Console.WriteLine("3 - Fizzbuzz");
            Console.WriteLine("");

            Console.Write("Which game do you want to play?: ");
            userGameChoice = Console.ReadLine();

            if (userGameChoice == "1")
            {
                GuessTheNumber();
            }
            else if (userGameChoice == "2")
            {
                CoinFlip();
            }
            else if (userGameChoice == "3")
            {
                FizzBuzz();
            }


            Console.WriteLine("Press any key to close the program. . .");
            Console.ReadKey(true);
        }
        static void GuessTheNumber()
        {
            Random random = new Random();
            bool stillPlaying = true;
            int userNumberDelimiter;

            Console.Write("Please enter a number for the limiter (Example: 1 to X (X = 20)): ");

            while (!int.TryParse(Console.ReadLine(), out userNumberDelimiter) || (userNumberDelimiter <= 0))//working
            {
                Console.Clear();
                Console.Write("The number delimiter must not be negative or equals to 0\n");
                Console.Write("Try again, enter the number delimiter: ");
            }

            Console.Write("Find the correct number: ");

            int correctGuess = random.Next(1, userNumberDelimiter);

            while (stillPlaying)
            {
                int userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess == correctGuess)
                {
                    Console.WriteLine($"Congrats, you´ve find the correct number: {correctGuess}");
                    stillPlaying = false;
                }
                else
                {
                    Console.Write("Incorrect guess, try again: ");
                }
            }
        }

        static void CoinFlip()
        {
            Random randomCoinFlip = new Random();

            int heads = 1;
            int userCoinSide;
            bool stillPlaying = true;


            while (stillPlaying)
            {
                Console.Write("Which side of the coin you want? [heads = 1 / tails = 2]: ");

                //a falta de logica na hora do raciocionio que está quebrando pra progredir
                if (!int.TryParse(Console.ReadLine(), out userCoinSide) || (userCoinSide != 1 && userCoinSide != 2))//working
                {
                    Console.WriteLine("You must choose between two sides, try again");
                }
                else
                {
                    int flippedSide = randomCoinFlip.Next(1, 3);

                    if (userCoinSide == flippedSide)
                    {
                        Console.WriteLine($"It´s {(flippedSide == heads ? "heads" : "tails")}, the player won");
                    }
                    else
                    {
                        Console.WriteLine($"It´s {(flippedSide == heads ? "heads" : "tails")}, the player lose");
                    }
                }
            }
        }
        //make an option for the automatic one, and an option for the user actually enter if he thinks its fizz or buzz or fizbuzz
        //and just press enter if its none of them
        static void FizzBuzz()
        {
            int fizz = 3,
                buzz = 5,
                userDelimiterNumber;

            bool stillPlaying = true;

            string userAnswerGuess = string.Empty;


            Console.WriteLine("Fizzbuzz is a game about math, basically these are the rules: ");
            Console.WriteLine("Every num divisible by 3 is Fizz, by 5 is buzz and by both 3 & 5 is Fizzbuzz!");
            Console.WriteLine("We have two options for the game, the automatic one [1]: Just enter a delimiter number, and watch");
            Console.WriteLine("The manual [2]: here you actually will enter if the number is a fizz/buzz/fizzbuzz or none of them");

            Console.Write("\nWhat is gonna be for now?: ");

            string userChoose = Console.ReadLine();

            if (userChoose == "1")
            {
                Console.Write("Enter a delimiter number: ");

                while (stillPlaying)
                {
                    if (!int.TryParse(Console.ReadLine(), out userDelimiterNumber) || (userDelimiterNumber <= 0))
                    {
                        Console.WriteLine("The number must be superior than 0, and must be an actual number.");
                        Console.Write("Try again. Enter the delimiter number: ");
                    }
                    else
                    {
                        for (int i = 1; i <= userDelimiterNumber; i++)
                        {
                            //just take 15 as example, by 5 its gonna have rest 3, and by 3 its gonna be 0
                            if (i % fizz == 0 && i / buzz == 3)
                            {
                                Console.WriteLine("{0} is a fizzbuzz", i);
                            }
                            else if (i % fizz == 0)
                            {
                                Console.WriteLine("{0} is fizz", i);
                            }
                            else if (i % buzz == 0)
                            {
                                Console.WriteLine("{0} is buzz", i);
                            }
                            else
                            {
                                Console.WriteLine("{0}", i);
                                stillPlaying = false;
                            }
                        }
                    }
                }
            }
            //make a comparator, and when the user ends the game, its gonna show how many he guessed right and which not
            else if (userChoose == "2")
            {
                Console.Write("Enter a delimiter number: ");

                while (stillPlaying)
                {
                    if (!int.TryParse(Console.ReadLine(), out userDelimiterNumber) || (userDelimiterNumber <= 0))
                    {
                        Console.WriteLine("The number must be superior than 0, and must be an actual number.");
                        Console.Write("Try again. Enter the delimiter number: ");
                    }
                    else
                    {
                        for (int i = 1; i <= userDelimiterNumber; i++)
                        {
                            Console.Write("{0} is a?: ", i);
                            userAnswerGuess = Console.ReadLine();

                            stillPlaying = false;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("You must enter a valid parameter. Try again.");
            }
        }
    }
}




