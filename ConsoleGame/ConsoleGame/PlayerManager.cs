using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace ConsoleGame
{
    public class PlayerManager : IOutputable
    {
        List<Player> _players;

        public PlayerManager()
        {
            _players = new List<Player>();
        }

        public PlayerManager AddPlayer(Player player)
        {
            _players.Add(player);
            return this;
        }

        public List<string> Output()
        {
            Debug.Assert(_players.Count > 0);

            List<string> output = new List<string>();
            output.Add("・プレイヤー");
            output.Add(string.Empty);

            foreach(var p in _players) 
            {
                output.Add(p._name);
                output.Add($"HP: {p._hp}");
                output.Add(string.Empty);
            }

            return output;
        }
    }
}
