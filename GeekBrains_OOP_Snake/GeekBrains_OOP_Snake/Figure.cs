using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains_OOP_Snake
{
    class Figure
    {
        protected List<Point> pList;
        public void Draw()
        {
            foreach (Point point in pList)
            {
                point.Draw();
            }
        }
    }
}
