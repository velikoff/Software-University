using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PeaceOfCake
{
    class Program
    {
        private static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());
          
                long nominator = (a * d) + (b * c);
                long denominator = b * d;
                long result = nominator/denominator;

                if (result < 1)
                {
                    decimal resDecimal = (decimal) nominator/denominator;
                    Console.WriteLine("{0:0.0000000000000000000000}", resDecimal);
                }
                else
                {
                    Console.WriteLine(result);
                }

                Console.WriteLine("{0}/{1}", nominator, denominator);
            }
        
    }
}
