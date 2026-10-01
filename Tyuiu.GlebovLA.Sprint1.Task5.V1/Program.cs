using System;
using Tyuiu.GlebovLA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.GlebovLA.Sprint1.Task5.V1
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами           *");
            Console.WriteLine("* (x, y). Ответ привести к целому с помощью класса Convert.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            Console.WriteLine("Введите координату x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            int res = ds.DistanceBetweenDots(x1, y1, x2, y2);

            Console.WriteLine();
            Console.WriteLine("Расстояние между точками = " + res);
            Console.ReadKey();
        }
    }
}