using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public abstract class CharacterBase
    {
        public int _id;
        public string _name;
        public int _max_hp;
        public int _current_hp;
        public int _attack;
        public int _deffence;
        public int _speed;

        public CharacterBase()
        {
        }
    }
}
