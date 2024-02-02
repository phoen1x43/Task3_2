using System;

namespace Task3_2
{
    sealed class OneArray : BaseForArrays
    {
        public OneArray(int columns, bool t = false) : base(1, 0, t) {}
        public override void FillByUser(int strings, int columns)
        {
            Console.WriteLine("Введите количество элементов одномерного массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i<n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public override void RndFill(int strings, int columns)
        {
            Random rand = new Random();
            int n = rand.Next(1, 15);
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 100);
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public override double CalculateAverageArray(int n)
        {
            int count = 0;
            foreach (int i in array)
            {
                count += i;
                Console.WriteLine("Среднее значение в одномерном массиве:");
                return count / n;
            }
        }

        public override void PrintArray()
        {
            Console.WriteLine("Одномерный массив:");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

    }

}
    



