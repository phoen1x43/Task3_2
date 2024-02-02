using System;

namespace Task3_2
{
    sealed class TwoArray : BaseForArrays
    {
        public TwoArray(int strings, int columns, bool t = false) : base(1, 1, t) {}
        public override void FillByUser()
        {
            Console.WriteLine("Введите количество строк");
            int strings = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[strings, columns];
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("Введите элемент массива");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.Write(array[i, j] + " ");
                }
            }
            Console.WriteLine();
        }

        public override int RndFill()
        {
            Random rand = new Random();
            Console.WriteLine("Введите количество строк");
            int strings = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[strings, columns];
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = rand.Next(0, 100);
                }
            }
            Console.WriteLine();
        }

        public override double CalculateAverageArray(int[,] array)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    count += array[i, j];
                    Console.WriteLine("Среднее значение в многомерном массиве:");
                }
            }
            return (double)count / (array.GetLength(0) * array.GetLength(1));
        }

        public override void PrintArray(int[,] array)
        {
            Console.WriteLine("Многомерный массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}