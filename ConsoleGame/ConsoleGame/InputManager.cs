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
        public List<string> Output()
        {
            List<string> output = new List<string>();
            return output;
        }
    }
}
