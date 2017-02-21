using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine//ДЗ вертикальная линия
    {
        List<point> pList;//линия, это не что иное, как список точек

        public VerticalLine(int yTop, int yBottom, int x, char sym)// координаты и значечение,
             //по которым будет рисоваться линия и как она будет выглядеть
        {
            pList = new List<point>();
            for (int y = yTop; y <= yBottom; y++)//переменная x будет получать знач от xLeft до xRight
            {
                point p = new point(x, y, sym);
                pList.Add(p);

            }
            // а теперь научимся создавать произвольные линии
            /* point p1 = new point(1, 4, '-');
             point p2 = new point(2, 4, '-');
             point p3 = new point(3, 4, '-');
             pList.Add(p1);
             pList.Add(p2);
             pList.Add(p3);*/
        }
        public void Draw()
        {
            foreach (point p in pList)
            {
                p.Draw();
            }
        }
    }
}
