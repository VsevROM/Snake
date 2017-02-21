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
            point p1 = new point(1, 3, '*');// new point()это не только объект, но и вызов ф-ии КОНСТРУКТОР
            // класс можт работать не только с данными, но и с методами, фун-ми
            p1.Draw();//вызываем метод из класса point для нашей точки

            point p2 = new point(4, 5, '$'); 
            p2.Draw();

            Console.ReadLine();//программа не закроется сама пока пользователь не нажмет Enter
        }
 
    }
}
