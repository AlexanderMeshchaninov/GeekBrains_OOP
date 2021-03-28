using System;
using System.Collections.Generic;

namespace GeekBrains_OOP_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            //Point p2 = new Point(4, 5, '#');
            //p2.Draw();

            HorizontalLines hline = new HorizontalLines(0, 20, 0, '+');
            hline.Draw();

            VerticalLine vline = new VerticalLine(0, 20, 0, '+');
            vline.Draw();

            VerticalLine vline2 = new VerticalLine(0, 20, 20, '+');
            vline2.Draw();

            HorizontalLines hline2 = new HorizontalLines(0, 20, 20, '+');
            hline2.Draw();

            Console.ReadKey();
        }
	}
}
