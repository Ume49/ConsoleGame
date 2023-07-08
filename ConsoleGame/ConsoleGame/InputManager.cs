namespace ConsoleGame
{
    public class InputManager : Interface.Output
    {
        public enum Phase
        {
            What,
            Who,
        }

        Phase _phase;
        PlayerManager _player_manager;
        CommandManager _command_manager;

        Command? _current_command;
        public void Output()
        {
            List<string> output = new List<string>();
            var player = _player_manager.CurrentPlayer;
            
            Console.WriteLine($"  選択キャラ：{player._name}");

            Console.WriteLine("どうする？");
            Console.WriteLine("選びたい行動を入力してください");
            Console.WriteLine("選びたい行動のキーを入力してからEnter");
            Console.WriteLine("  {選びたい行動} : {対応するキー}");
            Console.WriteLine();

            switch (_phase)
            {
                case Phase.What:
                    Console.WriteLine( "  攻撃 : 1 , 防御 : 2 , 特殊行動 : 3");
                    break;
                case Phase.Who:
                    Console.WriteLine($"  対象を選択してください");
                    Console.WriteLine($"  戻る : N");

                    throw new NotImplementedException();
            }
        }
        }
    }
}
