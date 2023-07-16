using System.Diagnostics;

namespace ConsoleGame
{
    public class InputManager
    {
        public enum Phase
        {
            What,
            Who,
        }

        public enum Result
        {
            Continue,
            BackwardPlayer,
            End,
        }

        Phase _phase;

        Command _current_command;
        Player? _current_player;

        List<CharacterBase> _current_turn_characters;

        bool? _chara_select_returnable;

        public InputManager() {
            _phase = Phase.What;
            _current_command = new Command();
            _current_turn_characters = new List<CharacterBase>();
            _chara_select_returnable = null;
        }
        public void Clear()
        {
            _phase = Phase.What;
            _current_command = new Command();
            _chara_select_returnable = null;
            _current_turn_characters.Clear();
        }

        public Player CurrentSelectPlayer
        {
            set => _current_player = value;
        }

        public bool CharaSelectReturnable
        {
            set => _chara_select_returnable = value;
        }

        public Command CurrentCommand
        {
            get {
                return _current_command;
            }
        }

        public void AddCurrentTurnCharacter(List<CharacterBase> list)
        {
            _current_turn_characters.AddRange(list);
        }

        public Result Question()
        {
            Debug.Assert(_current_player != null);
            Debug.Assert(_current_turn_characters.Count > 0);
            Debug.Assert(_current_turn_characters != null);
            Debug.Assert(_chara_select_returnable != null);

            Console.WriteLine($"  選択キャラ：{_current_player._name}");

            Console.WriteLine("選びたい行動を入力してください");
            Console.WriteLine("選びたい行動のキーを入力してからEnter");
            Console.WriteLine("  {選びたい行動} : {対応するキー}");
            Console.WriteLine();

            switch (_phase)
            {
                case Phase.What:
                    Console.WriteLine("なにをする？");
                    Console.WriteLine("  攻撃 : 1 , 防御 : 2 , 特殊行動 : 3");
                    if (_chara_select_returnable.Value)
                    {
                        Console.WriteLine("  前のキャラに戻る : N");
                    }
                    break;
                case Phase.Who:
                    Console.WriteLine("誰に？");
                    for(int i = 0; i<_current_turn_characters.Count; i++)
                    {
                        Console.WriteLine($"{_current_turn_characters[i]._name} : {i}");
                    }
                    Console.WriteLine("行動選択へ戻る : N");
                    break;
            }

            var input = Console.ReadLine();

            throw new NotImplementedException();
            // inputから入力を判定・コマンドを作成するなりreturnするなり対応

            if(input == "N")
            {
                if (BackwardPhase())
                {
                    return Result.BackwardPlayer;
                }
                else
                {
                    return Result.Continue;
                }
            }

            MakeCommand(input);
        }

        private void MakeCommand(string input)
        {
            switch(_phase)
            {
                case Phase.What:
                    switch (input)
                    {
                        case "1":
                            _current_command = new Command();
                            _current_command.act = Command.Act.Attack;
                            _current_command.who = _current_player;
                            break;
                        case "2":


                            break;
                        case "3":
                            break;
                    }
                    break;
                case Phase.Who:

                    break;
            }
        }

        private bool BackwardPhase()
        {
            if(_phase == Phase.What)
            {
                return true;
            }

            _phase--;
            return false;
        }
    }
}
