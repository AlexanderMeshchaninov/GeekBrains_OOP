using System;
using System.Collections.Generic;

namespace GeekBrains_OOP_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            Console.WriteLine();

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }*/

            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');
            Point p3 = new Point(5, 7, '^');
            Point p4 = new Point(2, 8, '@');
            Point p5 = new Point(9, 2, '!');
            Point p6 = new Point(1, 4, '%');

            List <Point> pList = new List<Point>();

            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);
            pList.Add(p6);

            foreach (var point in pList)
            {
                point.Draw();
            }

            Console.ReadKey();
        }
	}
}
