using System;

namespace guess_the_number
{
    internal class Fizzbuzz
    {
        //make an option for the automatic one, and an option for the user actually enter if he thinks its fizz or buzz or fizbuzz
        //and just press enter if its none of them
        public void FizzBuzz()
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
