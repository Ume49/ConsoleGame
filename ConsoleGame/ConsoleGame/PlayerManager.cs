﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            List<string> output = new List<string>();

            return output;
        }
    }
}
