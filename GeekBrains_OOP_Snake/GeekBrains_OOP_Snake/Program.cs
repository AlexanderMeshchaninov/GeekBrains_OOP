using System;
using System.Collections.Generic;

namespace GeekBrains_OOP_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(83, 25);
            Console.SetBufferSize(83, 25);

            //Отрисовка рамки
            HorizontalLines upLine = new HorizontalLines(0, 78, 0, '+');
            HorizontalLines downLine = new HorizontalLines(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');

            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            p.Draw();

            Employee first = new Employee();

            first.Age = 29;
            first.Name = "Alexander";
            first.Position = "Head of office";
            first.Sex = "Man";




            Console.ReadKey();
        }
	}
}
