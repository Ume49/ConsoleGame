// エントリポイント

using ConsoleGame;

TextGenerater text_generater = new TextGenerater();

EnemyManager enemy_manager = new EnemyManager();
text_generater.AddOutput(enemy_manager);

PlayerManager player_manager = new PlayerManager();
text_generater.AddOutput(player_manager);

{
    Enemy enemy_slime = new Enemy();
    enemy_slime._name = "岩スライム";
    enemy_slime._hp = 10;
    enemy_slime._attack = 1;
    enemy_slime._deffence = 2;
    enemy_manager.AddEnemy(enemy_slime);

    Enemy enemy_kobold = new Enemy();
    enemy_kobold._name = "コボルド";
    enemy_kobold._hp = 18;
    enemy_kobold._attack = 3;
    enemy_kobold._deffence = 0;
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