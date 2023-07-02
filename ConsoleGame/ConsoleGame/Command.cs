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
        public CharacterBase? who;
        public CharacterBase? target;
    }
}
