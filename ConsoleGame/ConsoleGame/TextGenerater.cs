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

        public TextGenerater Refresh()
        {
            Reset();

#if DEBUG
            Console.WriteLine("#デバッグモード");
            Console.WriteLine();
#endif

            foreach(var e in _elements)
            {
                var list = e.Output();

                list.ForEach(x => Console.WriteLine(x));
            }

            return this;
        }

        public TextGenerater AddOutput(IOutputable output)
        {
            _elements.Add(output);
            return this;
        }
    }
}
