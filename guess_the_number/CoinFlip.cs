using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess_the_number
{
    internal class CoinFlip
    {
        public void CoinFlipGame()
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
    }
}
