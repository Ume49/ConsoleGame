using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class CommandManager : IOutputable
    {
        public enum Phase
        {
            Init,
        }

        List<Command> _commands;

        private Phase _phase;
            

        public CommandManager() {
            _commands = new List<Command>();
        }

        public List<string> Output()
        {
            List<string> output = new List<string>();

            return output;
        }

        public CommandManager AddCommand(in Command command)
        {
            _commands.Add(command);
            return this;
        }
    }
}
