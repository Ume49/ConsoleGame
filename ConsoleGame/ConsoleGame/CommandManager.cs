namespace ConsoleGame
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

        public void SortCommand()
        {
            _commands = _commands.OrderBy(c => c.speed).ThenBy(x => Guid.NewGuid()).ToList();
        }
    }
}
