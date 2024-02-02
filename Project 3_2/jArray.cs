using System;

namespace Task3_2
{
    sealed class jArray : BaseForArrays
    {
        public jArray(int strings, bool t = false) : base(strings, 1, t) {}

        public override void FillByUser()
        {
            Console.WriteLine("Введите количество строк: ");
            int strings = Convert.ToInt32(Console.ReadLine());
            int[][] array = new int[strings][];
            for (int i = 0; i < strings; i++)
            {
                Console.WriteLine("Введите количество столбцов: ");
                int columns = Convert.ToInt32(Console.ReadLine());
                array[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("Введите элемент ступенчатого массива: ");
                    array[i][j] = Convert.ToInt32(Console.ReadLine());
                    Console.Write(array[i][j] + " ");
                }
                Console.Write('\n');
            }
            Console.WriteLine();
        }

        public override void RndFill()
        {
            Random rand = new Random();
            Console.WriteLine("Введите количество строк: ");
            int strings = Convert.ToInt32(Console.ReadLine());
            int[][] array = new int[strings][];
            for (int i = 0; i < strings; i++)
            {
                Console.WriteLine("Введите количество столбцов: ");
                int columns = Convert.ToInt32(Console.ReadLine());
                array[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    array[i][j] = rand.Next(0, 100);
                    Console.Write(array[i][j] + " ");
                }
                Console.Write('\n');
            }
            Console.WriteLine();
        }

        public double CalculateAverageArray(int strings, int columns)
        {   
            int N = 0;
            int sum = 0;
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    N++;
                    sum += array[i][j];
                    Console.WriteLine("Среднее значение в ступенчатом массиве:");
                }
            }
            return sum / N;   
        }

        public override void PrintArray(int strings, int columns)
        {
            Console.WriteLine("Ступенчатый массив");
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.Write('\n');
            }
            Console.WriteLine();
        }
    }

}
