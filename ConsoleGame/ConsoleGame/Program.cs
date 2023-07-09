// エントリポイント

using ConsoleGame;


EnemyManager enemy_manager = new EnemyManager();

PlayerManager player_manager = new PlayerManager();

CommandManager command_manager = new CommandManager();

InputManager input_manager = new InputManager();

BattlePhase battlePhase = BattlePhase.TurnInit;

int turn_count = 0;

{
    Enemy enemy_slime = new Enemy(
            name: "岩スライム",
            max_hp: 10,
            attack: 1,
            deffence: 2
        );
    enemy_manager.AddEnemy(enemy_slime);

    Enemy enemy_kobold = new Enemy(
            name: "コボルド",
            max_hp: 18,
            attack: 3
        );
    enemy_manager.AddEnemy(enemy_kobold);
}

{
    Player player_sowrdman = new Player(
            name: "剣士",
            max_hp: 10,
            attack: 3
        );
    player_manager.AddPlayer(player_sowrdman);

    Player player_sorcerer = new Player(
            name: "魔法使い",
            max_hp: 6,
            attack: 1
        );
    player_manager.AddPlayer(player_sorcerer);
}

do
{
    Console.Clear();

#if DEBUG
    Console.WriteLine("＊デバッグモード");
    Console.WriteLine();
#endif

    Console.WriteLine($"ターン : {turn_count}");

    enemy_manager .Output();
    player_manager.Output();

    switch (battlePhase)
    {
        case BattlePhase.TurnInit:
            input_manager.CurrentSelectPlayer = player_manager.CurrentPlayer;

            input_manager.AddCurrentTurnCharacter(player_manager.CurrentAliveCharacterList);
            input_manager.AddCurrentTurnCharacter(enemy_manager .CurrentAliveCharacterList);

            input_manager.CharaSelectReturnable = player_manager.CanBackward;

            turn_count++;
            battlePhase = BattlePhase.Input;
            break;
        case BattlePhase.Input:
            if (input_manager.Question())
            {
                Command command = input_manager.CurrentCommand;
                command_manager.AddCommand(command);

                if (player_manager.CanForward)
                {
                    player_manager.ForwardPlayer();
                }
                else
                {
                    battlePhase = BattlePhase.EnemyThink;
                }
            }
            break;
        case BattlePhase.EnemyThink:
            command_manager.AddCommand(enemy_manager.ThinkEnemyCommand());
            battlePhase = BattlePhase.Result;
            break;
        case BattlePhase.Result:
            command_manager.SortCommand();

            // foreach

            // 行動表示

            // 結果表示
            break;
    }
}
while (true);