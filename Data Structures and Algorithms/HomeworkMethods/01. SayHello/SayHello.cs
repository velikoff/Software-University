using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SayHello
{
    class SayHello
    {
        static void Main(string[] args)
        {
            printName();
        }

        public static void printName()
        {
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", input);
        }
    }
}
