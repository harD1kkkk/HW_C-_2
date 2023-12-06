using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Person : IOutput
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Show()
        {
            Console.WriteLine("Name: " + name + ", Age: " + age);
        }

        public void Show(string info)
        {
            Console.WriteLine("Name: " + name + ", Age: " + age + ", Info: " + info);
        }
    }
}
