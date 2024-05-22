using System;


//e esse ingles do paraguai, minha nossa
/* a random generated number system, the user will need to guess the number between any number he has inputed
 */


namespace guess_the_number
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Lucky games";

            Console.WriteLine("Games avaiable for now: ");
            Console.WriteLine("1 - Guessing number");
            Console.WriteLine("2 - Coin Spin");
            Console.WriteLine("E - Close the game");


            Console.Write("Which one do you want to play?: ");
            string userChoose = Console.ReadLine();
            bool stillChoosing = true;

            while (stillChoosing)
            {
                if (userChoose == "1")
                {
                    GuessingGame();
                }
                else if (userChoose == "2")
                {
                    CoinSpin();
                }
                else if (userChoose == "E")
                {
                    Console.WriteLine("Press any key to close the program. . .");
                    Console.ReadKey();
                    stillChoosing = false;
                }
            }
        }

        //só funciona, mas, da pra ser melhor
        static void GuessingGame()
        {
            Random random = new Random();

            Console.Write("Enter a number to be the dilimited scope: ");
            int delimitedScope = Convert.ToInt32(Console.ReadLine());

            int correctGuess = random.Next(delimitedScope);

            bool stillPlaying = true;

            Console.Write("User guess: ");

            while (stillPlaying)
            {
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == correctGuess)
                {
                    Console.WriteLine("The correct number was {0}, Congratulations!", correctGuess);
                    Console.WriteLine("Press any key to close the game. . .");
                    Console.ReadKey();
                    stillPlaying = false;
                }
                else if (userGuess != correctGuess)
                {
                    Console.Write("Try again, guess the number: ");
                }
            }
        }

        //codigo mais merda que esse abaixo impossivel, salvei pra ver minha evolução no futuro (eu espero)
        static void CoinSpin()
        {
            Random coinFlip = new Random();

            int flippedSide = coinFlip.Next(2);

            Console.Write("Head or tails?: ");
            string userSide = Console.ReadLine();

            if (userSide == "head" && flippedSide == 1)
            {
                Console.WriteLine("It´s heads.");
                Console.WriteLine("Press any key to continue. . .");
                Console.ReadKey();
            }
            else if (userSide == "tails" && flippedSide == 2)
            {
                Console.WriteLine("it´s tails.");
                Console.WriteLine("Press any key to continue. . .");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Its just head or tails mate, try again.");
            }
        }
    }
}
