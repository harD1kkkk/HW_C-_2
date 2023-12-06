// See https://aka.ms/new-console-template for more information
using ConsoleApp12;

class Program
{
    static void Main(string[] args)
    {

        int[] array = { 5, 3, 7, 1, 9, 4, 2, 6, 8 };

        ArrayMath math = new ArrayMath(array);


        Console.WriteLine("The array is:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
        Console.WriteLine("The maximum of the array is: " + math.Max());

        Console.WriteLine("The minimum of the array is: " + math.Min());

        Console.WriteLine("The average of the array is: " + math.Avg());
        int valueToSearch = 4;
        Console.WriteLine("The value " + valueToSearch + " is in the array: " + math.Search(valueToSearch));
    }
}