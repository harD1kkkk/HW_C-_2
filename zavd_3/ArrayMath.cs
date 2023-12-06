using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class ArrayMath : IMath
    {
        private int[] array;

        public ArrayMath(int[] array)
        {
            this.array = array;
        }

        public int Max()
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }


        public int Min()
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public double Avg()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double avg = (double)sum / array.Length;
            return avg;
        }

        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }
    }
}