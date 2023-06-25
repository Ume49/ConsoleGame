// エントリポイント

using ConsoleGame;

TextGenerater text_generater = new TextGenerater();

EnemyManager enemy_manager = new EnemyManager();

{
    Enemy enemy_slime = new Enemy();
    enemy_slime.name = "岩スライム";
    enemy_slime.hp = 10;
    enemy_slime.attack = 1;
    enemy_slime.deffence = 2;
    enemy_manager.AddEnemy(enemy_slime);

    Enemy enemy_kobold = new Enemy();
    enemy_kobold.name = "コボルド";
    enemy_kobold.hp = 18;
    enemy_kobold.attack = 3;
    enemy_kobold.deffence = 0;
    enemy_manager.AddEnemy(enemy_kobold);
}

text_generater.Refresh();