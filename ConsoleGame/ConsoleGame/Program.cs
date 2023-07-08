// エントリポイント

using ConsoleGame;


EnemyManager enemy_manager = new EnemyManager();

PlayerManager player_manager = new PlayerManager();

BattlePhase battlePhase = BattlePhase.Input;

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
#if DEBUG
    Console.WriteLine("＊デバッグモード");
    Console.WriteLine();
#endif

    // エネミーとプレイヤーの情報表示
    enemy_manager.Output();
    player_manager.Output();

    switch (battlePhase)
    {
        case BattlePhase.Input:
            // switch
                // 何をするのか
                // 誰にするのか
            break;
        case BattlePhase.Result:
            // コマンドを優先度順にソート

            // foreach

            // 行動表示

            // 結果表示
            break;
    }
}
while (true);