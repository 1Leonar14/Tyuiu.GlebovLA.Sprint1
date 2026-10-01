using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GlebovLA.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length < 2)
            {
                return false;
            }
            char first = value[0];
            return value.IndexOf(first, 1) >= 0;
        }
    }
}