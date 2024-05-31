using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//colocar um sistema de billboard, e sempre que o jogo acabar, retorne um placarScore var direto da função, pra ser
//adicionado na main tipo assim: static int GuessTheNumber() /return placarScore;

namespace ConsoleGames
{
    internal class Scoreboard
    {
        //para cada jogo, terá um scoreboard com somatoria de pontos/vezes jogadas/vezes que ganhou ou perdeu e etc
        public int Score;
        public int TimesPlayed;
        public int TimesWon;
        public int TimesLost;

        public Scoreboard() { }
        public Scoreboard(//analise) 
        {
            
        }

    }
}
