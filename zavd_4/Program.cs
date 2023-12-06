// See https://aka.ms/new-console-template for more information
using ConsoleApp13;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 5, 3, 7, 1, 9, 4, 2, 6, 8 };

        MyArray myArray = new MyArray(array);

        Console.WriteLine("Initial array:");
        myArray.Show();

        Console.WriteLine("Maximum of the array: " + myArray.Max());

        Console.WriteLine("Minimum of the array: " + myArray.Min());

        Console.WriteLine("Average of the array: " + myArray.Avg());

        int valueToSearch = 4;
        Console.WriteLine("Value " + valueToSearch + " is in the array: " + myArray.Search(valueToSearch));

        myArray.SortAsc();

        Console.WriteLine("Array after sorting in ascending order:");
        myArray.Show();

        myArray.SortDesc();

        Console.WriteLine("Array after sorting in descending order:");
        myArray.Show();
    }
}