namespace ConsoleGame
{
    public class InputCommand
    {
        public string _command;
        public string _key;

        public InputCommand(string command, string key)
        {
            _command = command;
            _key = key;
        }

        public bool IsKeyValid(string input_key)
        {
            return input_key == _key;
        }
    }
}
