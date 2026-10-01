using System;
using Tyuiu.GlebovLA.Sprint1.Task4.V22.Lib;

namespace Tyuiu.GlebovLA.Sprint1.Task4.V22
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные         *");
            Console.WriteLine("* данные, вычисляет результат по формуле и печатает его на экране.        *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();
            Console.WriteLine("Введите значение x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine();
            Console.WriteLine("Результат = " + res);

            Console.ReadKey();
        }
    }
}