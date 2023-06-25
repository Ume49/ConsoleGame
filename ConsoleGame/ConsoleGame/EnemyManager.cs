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
            _enemies = new List<Enemy>();
        }

        public List<string> Output()
        {
            List<string> output = new List<string>(2);

            foreach (var e in _enemies)
            {
                output[0] += e._name;
                output[1] += $"HP: {e._hp}";

                int right_edge = Math.Max(output[0].Length, output[1].Length);
                output.ForEach(x => x.PadRight(right_edge + 1));
            }

            return output;
        }

        public EnemyManager AddEnemy(Enemy enemy)
        {
            _enemies.Add(enemy);
            return this;
        }
    }
}
