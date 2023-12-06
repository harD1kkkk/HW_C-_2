// See https://aka.ms/new-console-template for more information
using ConsoleApp11;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Yarik", 20);

        Console.WriteLine("Information of the person:");
        person.Show();

        Console.WriteLine("Information of the person and a message:");
        person.Show("Hi!");
    }
}