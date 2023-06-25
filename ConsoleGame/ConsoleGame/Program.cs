// エントリポイント

using ConsoleGame;

TextGenerater text_generater = new TextGenerater();

EnemyManager enemy_manager = new EnemyManager();
text_generater.AddOutput(enemy_manager);

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

text_generater.Refresh();