using System;
using Tyuiu.GlebovLA.Sprint1.Task1.V9.Lib;

namespace Tyuiu.GlebovLA.Sprint1.Task1.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Глебов Л. А. | ПКТБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле (1+3*x)/(4*y) и печатает его на экране.  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* (1 + 3 * x) / (4 * y)                                                   *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = ds.Calculate(x, y);

            Console.WriteLine();
            Console.WriteLine("Результат = " + result);

            Console.ReadKey();
        }
    }
}