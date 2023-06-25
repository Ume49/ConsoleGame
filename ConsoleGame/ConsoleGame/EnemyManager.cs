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
            List<string> output = new List<string>(2);

            foreach (var e in enemies)
            {
                output[0] += e.name;
                output[1] += $"HP: {e.hp}";
            }

            return output;
        }
    }
}
