using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//colocar nome de usuario/s e fazer como se fosse uma grande central de minijogos single or multiplayer local
//add an roll the dices game (take from my other repo just about that)

namespace ConsoleGames
{
    internal class Users
    {
        public string Name { get; set; }

        public Users() { }

        public Users(string _name)
        {
            Name = _name;
        }
    }
}
