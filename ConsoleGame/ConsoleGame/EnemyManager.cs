using System;
using System.Diagnostics;

namespace ConsoleGame
{
    public class EnemyManager : Interface.Output , Interface.CommandList
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
            output.Enter();

            foreach (var e in _enemies)
            {
                output.Add(e._name);
                output.Add($"HP: {e._current_hp} / {e._max_hp}");
                output.Enter();
            }

            return output;
        }

        public EnemyManager AddEnemy(Enemy enemy)
        {
            _enemies.Add(enemy);
            return this;
        }

        public List<Command> CommandList
        {
            get => throw new NotImplementedException();
        }
    }
}
