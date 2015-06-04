using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
           // double d = 12345.67;
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Reversed: {0}", ReverseNumber(d));
        }

         private static double ReverseNumber(double number)
        {
            return double.Parse(ReverseString(number.ToString()));
        }

        private static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
