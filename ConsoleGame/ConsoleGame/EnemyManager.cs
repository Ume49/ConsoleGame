using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class EnemyManager : IOutputable
    {
        List<Enemy> _enemies;

        public EnemyManager()
        {
            enemies = new List<Enemy>();
        }

        public List<string> Output()
        {
            return null;    // とりあえずnull
        }
    }
}
