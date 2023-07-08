using System;
using System.Diagnostics;

namespace ConsoleGame
{
    public class EnemyManager : Interface.Output , Interface.CurrentAliveCharacterList
    {
        List<Enemy> _enemies;

        public EnemyManager()
        {
            _enemies = new List<Enemy>();
        }

        public void Output()
        {
            Debug.Assert(_enemies.Count > 0);
            
            Console.WriteLine("・敵");
            Console.WriteLine();

            foreach (var e in _enemies)
            {
                Console.WriteLine($"  {e._name}");
                Console.WriteLine($"    HP: {e._current_hp} / {e._max_hp}");
                Console.WriteLine();
            }
        }

        public EnemyManager AddEnemy(Enemy enemy)
        {
            _enemies.Add(enemy);
            return this;
        }

        public List<CharacterBase> CurrentAliveCharacterList
        {
            get => _enemies.Select(x => (CharacterBase)x).ToList();
        }

        public List<Command> ThinkEnemyCommand()
        {
            throw new NotImplementedException();
        }
    }
}
