using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab2
{
    /* 
     1. Обязательная задача*. Дана длина L окружности. Найти ее радиус R и площадь S круга, ограниченного этой окружностью.
     2. Даны координаты двух противоположных вершин прямоугольника: (x1, y1), (x2, y2). 
        Стороны прямоугольника параллельны осям координат. Найти периметр и площадь данного прямоугольника.
     3. Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3). Найти его периметр и площадь,
        используя формулу для расстояния между двумя точками на плоскости. 
        Для нахождения площади треугольника со сторонами a, b, c использовать формулу Герона: S=SQRT(p(p-a)(p-b)(p-c)),  где
        p=(a+b+c)/2 — полупериметр.
     */
    class Program
    {
        static void Main(string[] args)
        {
            byte taskNumber;
            Console.Write("Введите номер решаемой задачи: ");
            taskNumber = Convert.ToByte(Console.ReadLine());
            while ((taskNumber != 1) & ((taskNumber != 2) & ((taskNumber != 3))))
            {
                Console.WriteLine("Задача с введенным номером отсутствует.");
                Console.Write("Введите номер решаемой задачи: ");
                taskNumber = Convert.ToByte(Console.ReadLine());
            }
            Console.WriteLine("Выбрана задача №{0}.", taskNumber);
            if (taskNumber == 1)
            {
                Task1();
            }
            else if (taskNumber == 2)
            {
                Task2();
            }
            else // taskNumber == 3
            {
                Task3();           
            }
            Console.ReadKey();
        }

        static void Task1()
        {
            double L;
            double R;
            double S;
            Console.WriteLine("Дана длина L окружности. Найти ее радиус R и площадь S круга, ограниченного этой окружностью.");
            Console.WriteLine("Введите длину окружности L.");
            Console.Write("L = ");
            L = Convert.ToDouble(Console.ReadLine());
            R = L / (2 * Math.PI);
            S = Math.PI * Math.Pow(R, 2);
            Console.WriteLine("Радиус окружности: R = {0}.", R);
            Console.WriteLine("Площадь круга: S = {0}.", S);
        }


        static void Task2()
        {
            double X1, X2, Y1, Y2, P, S, A, B;
            Console.WriteLine("Даны координаты двух противоположных вершин прямоугольника: (x1, y1), (x2, y2).");
            Console.WriteLine("Стороны прямоугольника параллельны осям координат. Найти периметр P и площадь S данного прямоугольника.");
            Console.Write("X1 = ");
            X1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y1 = ");
            Y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("X2 = ");
            X2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y2 = ");
            Y2 = Convert.ToDouble(Console.ReadLine());
            A = Math.Abs(X1-X2);
            B = Math.Abs(Y1 - Y2);
            P = 2 * (A + B);
            S = A * B;
            Console.WriteLine("Периметр прямоугольника: P = {0}.", P);
            Console.WriteLine("Площадь прямоугольника: S = {0}.", S);
        }

        static void Task3()
        {
            double X1, X2, X3, Y1, Y2, Y3, P, S, A, B, C;
            Console.WriteLine("Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3). Найти его периметр и площадь,");
            Console.WriteLine("используя формулу для расстояния между двумя точками на плоскости.");
            Console.WriteLine("Для нахождения площади треугольника со сторонами a, b, c использовать формулу Герона: S=SQRT(p(p-a)(p-b)(p-c)),  где");
            Console.WriteLine("p=(a+b+c)/2 — полупериметр.");
            Console.Write("X1 = ");
            X1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y1 = ");
            Y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("X2 = ");
            X2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y2 = ");
            Y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("X3 = ");
            X3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y3 = ");
            Y3 = Convert.ToDouble(Console.ReadLine());
            A = Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
            B = Math.Sqrt((X1 - X3) * (X1 - X3) + (Y1 - Y3) * (Y1 - Y3));
            C = Math.Sqrt((X2 - X3) * (X2 - X3) + (Y2 - Y3) * (Y2 - Y3));
            P = A + B + C;
            S = Math.Sqrt((P / 2) * ((P / 2)-A) * ((P / 2)-B) * ((P / 2)-C));
            // Console.WriteLine("A = {0}.", A);
            // Console.WriteLine("B = {0}.", B);
            // Console.WriteLine("C = {0}.", C);

            Console.WriteLine("Периметр треугольника: P = {0}.", P);
            Console.WriteLine("Площадь треугольника: S = {0}.", S);
        }
    }
}
