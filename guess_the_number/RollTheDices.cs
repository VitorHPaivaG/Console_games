using System;
using System.Threading;

namespace ConsoleGames
{
    internal class RollTheDices
    {
        //ask if the user wants to play again the game
        public void RollTheDicesGame()
        {
            int playerDiceRoll = 0,
                machineDiceRoll = 0,
                playerPoints = 0,
                machinePoints = 0,
                playerPointsTotalDiceSum = 0,
                machinePointsTotalDiceSum = 0,
                sleepingDelay = 800,
                turnCounter = 1,
                userChoosenTurns;

            bool stillPlaying = true;

            while (stillPlaying)
            {
                Random random = new Random();

                Console.Write("How many turns do you want to play?: ");
                while (!int.TryParse(Console.ReadLine(), out userChoosenTurns) || userChoosenTurns <= 0)
                {
                    Console.Write("The number of turns must be above 0! Try again: ");
                }

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
                    else if (playerDiceRoll > machineDiceRoll) { playerPoints++; }

                    else { machinePoints++; }
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

                Console.Write("\nDo you want to play again? [Y/N]: ");

                string playAgain = Console.ReadLine().ToUpper();

                if (playAgain.Equals("N"))
                {
                    Console.Write("This is the end of the game! Press any key to continue. . .");
                    Console.ReadKey(true);
                    stillPlaying = false;
                }
                else if (playAgain.Equals("Y"))
                {
                    Console.Write("Press any key to play again!\n");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.Write("Wrong parameter, try again!");
                    Console.ReadKey(true);
                    stillPlaying = false;
                }
            }
        }
    }
}
