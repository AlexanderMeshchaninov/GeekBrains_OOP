using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains_OOP_Snake
{
    class FoodCreator
    {
        int MapHeight { get; set; }
        int MapWidth { get; set; }
        char Sym { get; set; }

        Random rnd = new Random();

        public FoodCreator(int heigth, int width, char sym)
        {
            MapHeight = heigth;
            MapWidth = width;
            Sym = sym;
        }

        public Point CreateFood()
        {
            int x = rnd.Next(2, MapHeight -2);
            int y = rnd.Next(2, MapWidth - 2);
            return new Point(x, y, Sym);
        }
    }
}
