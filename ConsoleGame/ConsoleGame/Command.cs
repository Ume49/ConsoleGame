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
        public CharacterBase who;
        public List<CharacterBase>? target;
        public int speed;
    }
}
