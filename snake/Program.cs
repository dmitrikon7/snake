using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false;

            VerticalLine leftLine = new VerticalLine(0, 24, 0, '|');
            VerticalLine rigthLine = new VerticalLine(0, 23, 78, '|');
            HorizontalLine topLine = new HorizontalLine(1, 77, 0, '-');
            HorizontalLine bottomLine = new HorizontalLine(1, 77, 23, '-');

            Console.ForegroundColor = ConsoleColor.Blue;
            leftLine.Draw();

            Console.ForegroundColor = ConsoleColor.Blue;
            rigthLine.Draw();

            Console.ForegroundColor = ConsoleColor.Green;
            topLine.Draw();

            Console.ForegroundColor = ConsoleColor.Green;
            bottomLine.Draw();

            Console.ResetColor();
            Point p = new Point(40, 12, '*');
            p.Draw();
            Console.ReadLine();
        }
    }
}
