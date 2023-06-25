using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class Player
    {
        public string _name;
        public int _hp;
        public int _attack;

        public Player()
        {
            _name   = String.Empty;
            _hp     = 0;
            _attack = 0;
        }
    }
}
