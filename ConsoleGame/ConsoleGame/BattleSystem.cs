namespace ConsoleGame
{
    public class BattleSystem
    {
        PlayerManager _player_manager;
        EnemyManager _enemy_manager;
        CommandManager _command_manager;

        public BattleSystem(PlayerManager p, EnemyManager e, CommandManager c)
        {
            _player_manager     = p;
            _enemy_manager      = e;
            _command_manager    = c;
        }
    }
}
