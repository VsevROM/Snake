using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)//void - аргумент означающий,что метод ничего не возвращает
        {
            point p1 = new point(1, 1, '*');// new point()это не только объект, но и вызов ф-ии КОНСТРУКТОР
            // класс можт работать не только с данными, но и с методами, фун-ми
            p1.Draw();//вызываем метод из класса point для нашей точки

            point p2 = new point(2, 2, '$'); 
            p2.Draw();

            point p3 = new point(3, 3, '@');// Д.З создали еще 4 точки
            p3.Draw();

            point p4 = new point(4, 4, '&');
            p4.Draw();

            point p5 = new point(5, 5, 'L');
            p5.Draw();

            point p6 = new point(6, 6, 'M');
            p6.Draw();

            List<int> numList = new List<int>();// переменная numList = объект класса List, хранит список целочисленных переменных
            numList.Add(0);// теперь наш список содержит сразу 3 целочисленных переменных
            numList.Add(1);
            numList.Add(2);
            numList.Add(3);
            numList.Add(4);
            numList.Add(5);
            numList.Add(6);

            int x = numList[0];// чтобы получить доступ к переменным прописываем их порядковые номера
            int y = numList[1];
            int z = numList[2];
            int c = numList[3];
            int e = numList[4];
            int r = numList[5];
            int v = numList[6];

            foreach (int i in numList)// цикл в котором в элемент i поочередно,
            //на каждом витке цикла записываются переменны из списка
            {
                Console.WriteLine( i ); //через эту переменную знач выводятся на экран
            }

            numList.RemoveAt(0);//функция Remove убираем 0 порядковый номер из списка

            List <point> pList = new List<point>();//список из наших точек
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);
            pList.Add(p6);

            Console.ReadLine();//программа не закроется сама пока пользователь не нажмет Enter
        }
 
    }
}
