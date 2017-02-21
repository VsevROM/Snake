using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class point//класс - это тот же тип данных, как цифры и символы
        // может работать не только с данными, но и с функциями и методами
    {
        public int x, y;//объединили наши переменные в класс, что бы сократить код
        public char sym;//теперь вызовем этот класс в классе Program


        public point()// КОНСТРУКТОР
        {
        }

        public point(int _x, int _y, char _sym)// создали конструктор для точки
            //он будет рисовать точку каждый разс заданными пр-ми при вызове Draw point
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Draw()//после метода или ф-ии ; НЕ СТАВИМ
        {
            Console.SetCursorPosition(x, y);//указали координаты где выводить точку
            Console.Write(sym);//выводим символ в координатах указаных сверху
        }
}
}
