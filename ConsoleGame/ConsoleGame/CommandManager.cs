﻿namespace ConsoleGame
{
    public class CommandManager : Interface.Output
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

        public void Output()
        {
            throw new NotImplementedException();
        }

        public CommandManager AddCommand(in Command command)
        {
            _commands.Add(command);
            return this;
        }

        public CommandManager AddCommand(in List<Command> commands)
        {
            _commands.AddRange(commands);
            return this;
        }

        public void SortCommand()
        {
            _commands = _commands.OrderBy(c => c.speed).ThenBy(x => Guid.NewGuid()).ToList();
        }
    }
}
