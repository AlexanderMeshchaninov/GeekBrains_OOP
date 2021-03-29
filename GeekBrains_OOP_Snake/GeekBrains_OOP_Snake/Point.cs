using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains_OOP_Snake
{
    public class Point
    {
        public int X;
        public int Y;
        public char Sym;

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            Sym = p.Sym;
        }

        public Point(int x, int y, char sym)
        {
            X = x;
            Y = y;
            Sym = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Sym);
        }

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.RIGHT:
                    X = X + offset;
                    break;
                case Direction.LEFT:
                    X = X - offset;
                    break;
                case Direction.UP:
                    Y = Y + offset;
                    break;
                case Direction.DOWN:
                    Y = Y - offset;
                    break;
            }
        }

        public override string ToString()
        {
            return X + ", " + Y + ", " + Sym;
        }
    }
}
