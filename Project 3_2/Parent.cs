using System;

namespace Task3_2
{
    abstract class BaseForArrays
    {
        protected int[] array;
        public RndOrHands(int strings, int columns, bool t = false)
        {
            if (t == false)
            {
                array = RndFill(strings, columns);
            }
            else
            {
                array = FillByUser(strings, columns);
            }
        }
        public abstract void RndFill(int strings, int columns);

        public abstract void FillByUser(int strings, int columns);
        
        public abstract double CalculateAverageArray();
        public abstract void PrintArray();
    }
}