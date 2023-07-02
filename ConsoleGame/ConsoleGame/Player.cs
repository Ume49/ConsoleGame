namespace ConsoleGame
{
    public class Player : CharacterBase
    {
        public Player(
            string name,
            int max_hp,
            int attack,
            int deffence = 0,
            int speed = 0
            ) : base(
                    name,
                    max_hp,
                    attack,
                    deffence,
                    speed
                )
        {
        }

        public override void ExecuteCommand()
        {
            throw new NotImplementedException();
        }
    }
}
