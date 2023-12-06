using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class ArraySorter : ISort
    {
        private int[] array;

        public ArraySorter(int[] array)
        {
            this.array = array;
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

        public void PrintArray()
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
