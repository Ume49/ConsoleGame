using System.Data;
using System.Diagnostics;
using static ConsoleGame.Command;

namespace ConsoleGame
{
    public class PlayerManager : Interface.Output
    {
        List<Player> _players;
        int _index;

        readonly List<(Act command ,string name, string message)> _message_list;

        public PlayerManager()
        {
            _players = new List<Player>();
            _message_list = new List<(Act, string, string)>() { 
                (Act.Attack ,   "攻撃", "1"),
                (Act.Deffence,  "防御", "2"),
                (Act.Special,   "特殊", "3"),
            };
        }

        public PlayerManager AddPlayer(Player player)
        {
            _players.Add(player);
            _index = 0;
            return this;
        }

        public Player CurrentPlayer { get => _players[_index]; }

        public List<string> Output()
        {
            Debug.Assert(_players.Count > 0);

            List<string> output = new List<string>();
            output.Add("・プレイヤー");
            output.Enter();

            foreach(var p in _players) 
            {
                output.Add($"  {p._name}");
                output.Add($"    HP: {p._current_hp} / {p._max_hp}");
                output.Enter();
            }

            return output;
        }

        public bool IsMessageValid(string Message)
        {
            bool result = false;

            _message_list.ForEach(x => result |= (Message == x.message));

            return result;
        }

        public bool CanBackward { get => _index > 0; }
        public bool CanForward  { get => _index < _players.LastIndex(); }

        public PlayerManager ForwardPlayer()
        {
            _index++;

            Debug.Assert(_index < _players.Count);

            return this;
        }

        public PlayerManager BackwardPlayer()
        {
            _index--;

            Debug.Assert(_index >= 0);

            return this;
        }

        public Act ConvertCommand(string message)
        {
            return _message_list.Find(x => x.message == message).command;
        }
    }
}
