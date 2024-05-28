using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace guess_the_number
{
    internal class RollTheDices
    {
        //better write
        //more lucky games?
        //ask if the user wants to play again the game
        //do a total of games won by the player and the machine (if he want to play again ofc)
        //ask the user an name, or use the default = "player"
        public void RollTheDicesGame()
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
