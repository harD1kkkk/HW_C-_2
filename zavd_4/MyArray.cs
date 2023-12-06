using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class MyArray : IOutput, IMath, ISort
    {
        private int[] array;

        public MyArray(int[] array)
        {
            this.array = array;
        }

        public void Show()
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine(info + ":");
            Show();
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

        public void SortAsc()
        {
            Array.Sort(array);
        }

        public void SortDesc()
        {
            Array.Sort(array);
            Array.Reverse(array);
        }
    }
}
