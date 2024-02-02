using System;
using System.Linq.Expressions;

namespace Task3_2
{
    class Program
    {
         static void Main()
         {
            BaseForArrays[] baseForArrays = new BaseForArrays[3];

            baseForArrays[0] = new OneArray(7);
            baseForArrays[1] = new TwoArray(2, 5);
            baseForArrays[2] = new jArray(3);

            foreach (BaseForArrays item in baseForArrays)
            {
                item.PrintArray();
                Console.WriteLine("Среднее значение в массиве: " + item.CalculateAverageArray());
                Console.WriteLine();
            }
         }
    }
}