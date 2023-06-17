using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class TextGenerater
    {
        List<IOutputable> _elements;

        private void Reset()
        {
            Console.Clear();
        }

        public void Refresh()
        {
            Reset();

            // 描画処理
        }
    }
}
