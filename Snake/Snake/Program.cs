using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1, x2 =4, y1 = 3, y2 = 5;//не пишем на каждую переменную отдельно её тип, все в одной строке, чтобы сократить код
            char sym1 = '*', sym2 = '$';//указываем в одинарных скобках, это НЕ ТЕКСТ

            Draw(x1, y1, sym1);//в методе Draw нельзя указывать более 4 аргументов, поэтому пишем 2 раза
            Draw(x2, y2, sym2);

            Console.ReadLine();//программа не закроется сама пока пользователь не нажмет Enter
        }
 
        static void Draw (int x, int y, char sym)//так называемый процедурный метод
            //эта ф-ия позволяет нам не копировать несколько раз нижеприведенный код, а выполняет его
            //относительно количества вышенаписаных Draw
        {
            Console.SetCursorPosition(x, y);//указали координаты где выводить точку
            Console.Write(sym);//выводим символ в координатах указаных сверху
        }
    }
}
