namespace ConsoleGame
{
    public abstract class CharacterBase : Interface.ExecuteCommand
    {
        public int _id;
        public string _name;
        public int _max_hp;
        public int _current_hp;
        public int _attack;
        public int _deffence;
        public int _speed;

        public CharacterBase(
            string name,
            int max_hp,
            int attack,
            int deffence,
            int speed
            )
        {
            _id         = int.MinValue;
            _name       = name;
            _max_hp     = max_hp;
            _current_hp = max_hp;
            _attack     = attack;
            _deffence   = deffence;
            _speed      = speed;
        }

        protected bool ExistID { get => _id != int.MinValue; }

        public abstract void ExecuteCommand();
    }
}
