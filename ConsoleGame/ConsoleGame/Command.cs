namespace ConsoleGame
{
    public struct Command
    {
        public enum Act
        {
            Attack,
            Deffence,
            Special,
        }

        public Act act;
        public int who;
        public int target;
    }
}
