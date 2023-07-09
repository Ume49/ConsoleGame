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
            Backward,
            End,
        }

        Phase _phase;

        Command? _current_command;
        Player? _current_player;

        List<CharacterBase> _current_turn_characters;

        bool? _chara_select_returnable;

        public InputManager() {
            _phase = Phase.What;
            _current_command = null;
            _current_turn_characters = new List<CharacterBase>();
            _chara_select_returnable = null;
        }
        public void Clear()
        {
            _phase = Phase.What;
            _current_command = null;
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
                Debug.Assert(_current_command!= null);
                return (Command)_current_command;
            }
        }

        public void AddCurrentTurnCharacter(List<CharacterBase> list)
        {
            _current_turn_characters.AddRange(list);
        }

        public bool Question()
        {
            Debug.Assert(_current_player != null);
            Debug.Assert(_current_turn_characters.Count > 0);
            Debug.Assert(_current_turn_characters != null);

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
                    break;
                case Phase.Who:
                    Debug.Assert(_current_command != null);
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
        }

        private bool IsInputValid(string input)
        {
            switch(_phase)
            {
                case Phase.What:

                    break;
                case Phase.Who:
                    break;
            }
        }
    }
}
