using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11App1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Разработать структуру для решения линейного уравнения 0 = kx + b.Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
            //Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе.
            Console.WriteLine("Решение уравнения 0 = kx + b");
            Console.Write("Введите значение коэффициента k= ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение коэффициента b= ");
            double b = Convert.ToDouble(Console.ReadLine());
            TheEquation theEquation = new TheEquation(k, b);
            theEquation.Root();
            Console.ReadKey();
        }
        struct TheEquation
        {
            double k;
            double b;
            public TheEquation(double k, double b)
            {
                this.k = k;
                this.b = b;
            }

            public void Root()
            {
                if (k != 0)
                {
                    double x = -b / k;
                    Console.WriteLine($"Корень уравнения(Уравнение имеет 1 корень) x={x}");
                }
                else if (k == 0 && b == 0)
                {
                    Console.WriteLine($"Корень уравнения x=любое число");
                }
                else if (k == 0 && b != 0)
                {
                    Console.WriteLine("Нет решения");
                }
            }
        }
    }
}
