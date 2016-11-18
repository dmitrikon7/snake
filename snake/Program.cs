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
            Console.CursorVisible = false;

            Point p1 = new Point(1, 5, '-');
            Point p2 = new Point(2, 5, '-');
            Point p3 = new Point(3, 5, '-');
            Point p4 = new Point(4, 5, '-');
            Point p5 = new Point(5, 5, '-');
            Point p6 = new Point(6, 5, '-');
            Point p7 = new Point(7, 5, '|');
            Point p8 = new Point(7, 4, '|');
            Point p9 = new Point(7, 3, '|');
            Point p10 = new Point(7, 2, '*');
            p1.Draw();
            p2.Draw();
            p3.Draw();
            p4.Draw();
            p5.Draw();
            p6.Draw();
            p7.Draw();
            p8.Draw();
            p9.Draw();
            p10.Draw();

            Console.ReadLine();
        }
    }
}
