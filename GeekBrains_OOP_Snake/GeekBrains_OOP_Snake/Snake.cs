using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains_OOP_Snake
{
    class Snake : Figure
    {
        Direction Direction;
        public Snake(Point tail, int length, Direction direction)
        {
            Direction = direction;
            pList = new List<Point>();

            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, Direction);
                pList.Add(p);
            }
        }
        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, Direction);
            return nextPoint;
        }

        public void ControlKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    Direction = Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    Direction = Direction.RIGHT;
                    break;
                case ConsoleKey.UpArrow:
                    Direction = Direction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    Direction = Direction.DOWN;
                    break;
            }
        }
    }
}
