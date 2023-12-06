// See https://aka.ms/new-console-template for more information
namespace Myspace;
using ConsoleApp10;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 5, 3, 7, 1, 9, 4, 2, 6, 8 };
        ArraySorter sorter = new ArraySorter(array);

        Console.WriteLine("Initial array:");
        sorter.PrintArray();
        sorter.SortAsc();

        Console.WriteLine("Array after sorting in ascending order:");
        sorter.PrintArray();

        sorter.SortDesc();
        Console.WriteLine("Array after sorting in descending order:");
        sorter.PrintArray();
    }
}
