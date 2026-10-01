using System;
using Tyuiu.GlebovLA.Sprint1.Task6.V11.Lib;

namespace Tyuiu.GlebovLA.Sprint1.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Глебов Л. А. | ПКТБ-26-1";

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Работа со строками в C#                                        *");
            Console.WriteLine("* Задание #6                                                           *");
            Console.WriteLine("* Вариант #11                                                          *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТБ-26-1                    *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что первая *");
            Console.WriteLine("* буква строки входит в нее еще раз.                                   *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Введите текст:");

            string value = Console.ReadLine();
            bool result = ds.CheckeFirstLetterRepetition(value);
            Console.WriteLine();

            if (result)
            {
                Console.WriteLine("Первая буква строки входит в нее еще раз.");
            }
            else
            {
                Console.WriteLine("Первая буква строки больше не встречается.");
            }

            Console.ReadKey();
        }
    }
}