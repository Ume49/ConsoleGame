using System;
namespace ConsoleGame
{
    public static class TextsExtension
    {
        public static void Enter(this List<string> text)
        {
            text.Add(string.Empty);
        }
    }
}
