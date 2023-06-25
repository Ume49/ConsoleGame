using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

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
            Debug.Assert(_enemies.Count > 0);

            List<string> output = new List<string>(_enemies.Count * 3 + 2);

            output.Add("・敵");

            foreach (var e in _enemies)
            {
                output.Add(e._name);
                output.Add($"HP: {e._hp}");
                output.Add(string.Empty);
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
