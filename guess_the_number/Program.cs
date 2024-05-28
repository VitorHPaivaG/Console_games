using System;
using System.Threading;


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
            string userGameChoice = string.Empty;
            bool stillChoosing = true;
            int clearenceTimer = 1000;

            while (stillChoosing)
            {
                Console.Clear();

                Console.WriteLine("We have these console games for now: \n");
                Console.WriteLine("1 - GuessTheNumber");
                Console.WriteLine("2 - Coin-Flip");
                Console.WriteLine("3 - Fizzbuzz");
                Console.WriteLine("4 - RollTheDices");

                Console.Write("Which game do you want to play? [type E to close the console]: ");
                userGameChoice = Console.ReadLine().ToUpper();

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
                else if (userGameChoice == "4")
                {
                    RollTheDices();
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

        //better write
        //more lucky games?
        //ask if the user wants to play again the game
        //do a total of games won by the player and the machine (if he want to play again ofc)
        //ask the user an name, or use the default = "player"
        static void RollTheDices()
        {
            int playerDiceRoll = 0,
                machineDiceRoll = 0,
                playerPoints = 0,
                machinePoints = 0,
                playerPointsTotalDiceSum = 0,
                machinePointsTotalDiceSum = 0,
                sleepingDelay = 800,
                turnCounter = 1;

            Random random = new Random();

            Console.Write("How many turn do you want to play?: ");
            int userChoosenTurns = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < userChoosenTurns; i++)
            {
                playerDiceRoll = random.Next(1, 7);

                Console.WriteLine("==============================");
                Console.WriteLine("Press enter to roll the dices!");
                Console.WriteLine("==============================");
                Console.ReadLine();

                Thread.Sleep(sleepingDelay);

                Console.WriteLine("================");
                Console.WriteLine($"this is turn: {turnCounter++}");
                Console.WriteLine("================");


                Console.WriteLine($"player rolled a: {playerDiceRoll}");
                playerPointsTotalDiceSum += playerDiceRoll;

                machineDiceRoll = random.Next(1, 7);
                Console.WriteLine($"machine rolled a: {machineDiceRoll}");
                machinePointsTotalDiceSum += machineDiceRoll;

                Console.WriteLine("");

                if (playerDiceRoll == machineDiceRoll)
                {
                    playerDiceRoll--;
                    machineDiceRoll--;
                }
                else if (playerDiceRoll > machineDiceRoll)
                {
                    playerPoints++;
                }
                else
                {
                    machinePoints++;
                }
            }

            Console.WriteLine("==============================");
            Console.WriteLine("End of the game! The results..");
            Console.WriteLine("==============================");

            Console.WriteLine("");

            Thread.Sleep(sleepingDelay);

            Console.WriteLine($"player rounds score: {playerPoints}\nmachine rounds score: {machinePoints}");

            Console.WriteLine("");

            if (playerPoints > machinePoints)
            {
                Console.WriteLine("=====================");
                Console.WriteLine("player wons the game!");
                Console.WriteLine("=====================");

            }
            else if (playerPoints == machinePoints)
            {
                Console.WriteLine("==============");
                Console.WriteLine("that´s a draw!");
                Console.WriteLine("==============");
            }
            else
            {
                Console.WriteLine("=========================");
                Console.WriteLine("the machine wons the game");
                Console.WriteLine("=========================");
            }

            Console.WriteLine("");

            Console.WriteLine($"the total of sides points the player earned through the dice was: {playerPointsTotalDiceSum}");
            Console.WriteLine($"the total of sides points the machine earned through the dice was: {machinePointsTotalDiceSum}");

            Console.Write("This is the end of the game! Press any key to continue. . .");
            Console.ReadKey(true);
        }
    }
}







