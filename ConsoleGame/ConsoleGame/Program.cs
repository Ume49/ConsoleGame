// エントリポイント

using ConsoleGame;

TextGenerater text_generater = new TextGenerater();

EnemyManager enemy_manager = new EnemyManager();
text_generater.AddOutput(enemy_manager);

PlayerManager player_manager = new PlayerManager();
text_generater.AddOutput(player_manager);

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
    text_generater.Refresh();
    
    Console.ReadLine();
}
while (true);