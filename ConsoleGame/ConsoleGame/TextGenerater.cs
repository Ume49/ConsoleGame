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

        public TextGenerater()
        {
            _elements = new List<IOutputable>();
        }

        private void Reset()
        {
            Console.Clear();
        }

        public void Refresh()
        {
            Reset();

#if DEBUG
            Console.WriteLine("#デバッグモード");
#endif

            foreach(var e in _elements)
            {
                var list = e.Output();

                list.ForEach(x => Console.WriteLine(x));
            }
        }
    }
}
