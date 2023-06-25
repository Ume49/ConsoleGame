using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public struct Command
    {
        public enum Act
        {
            Attack,
            Deffence,
            Special,
        }

        public Act act;
        public int who;
        public int target;
    }
}
