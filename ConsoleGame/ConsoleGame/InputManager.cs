namespace ConsoleGame
{
    public class InputManager : Interface.Output
    {
        public enum Phase
        {
            What,
            Who,
        }

        Phase _phase;
        PlayerManager _player_manager;
        CommandManager _command_manager;
        public List<string> Output()
        {
            List<string> output = new List<string>();
            return output;
        }
    }
}
