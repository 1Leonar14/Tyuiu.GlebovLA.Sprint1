using System;
using Tyuiu.GlebovLA.Sprint1.Task3.V15.Lib;

namespace Tyuiu.GlebovLA.Sprint1.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Глебов Л. А. | ПКТБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Два автомобиля имеют скорости V1 км/ч и V2 км/ч соответственно,         *");
            Console.WriteLine("* находятся на расстоянии S км друг от друга и движутся в                 *");
            Console.WriteLine("* противоположные стороны. Определить расстояние между ними               *");
            Console.WriteLine("* через T часов. Ответ округлить до 3 знаков после запятой.               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();
            Console.WriteLine("Введите скорость первого автомобиля V1 км/ч:");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите скорость второго автомобиля V2 км/ч:");
            double v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите расстояние между автомобилями S км:");
            double S = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите время T ч:");
            double T = Convert.ToDouble(Console.ReadLine());

            double res = ds.DistanceOverTime(v1, v2, S, T);

            Console.WriteLine();
            Console.WriteLine("Расстояние между автомобилями = " + res + " км");

            Console.ReadKey();
        }
    }
}