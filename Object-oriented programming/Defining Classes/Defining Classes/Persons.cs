using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Persons
    {
        static void Main(string[] args)
        {
            Person person = new Person("Pesho", (byte)23, "pesho@gmail.com");
            Console.WriteLine(person);
        }
    }
}