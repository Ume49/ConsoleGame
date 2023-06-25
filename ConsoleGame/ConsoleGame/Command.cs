using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class Command
    {
        public enum Act
        {
            Attack,
            Deffence,
            Special,
        }

        Act act;
        int who;
    }
}
