using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x, y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            this.x = _x;
            this.y = _y;
            this.sym = _sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.WriteLine(this.sym);
        }
    }
}
