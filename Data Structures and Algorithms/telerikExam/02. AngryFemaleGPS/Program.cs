using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AngryFemaleGPS
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            long a = long.Parse(input);
            a = Math.Abs(a);
            long even = 0;
            long odd = 0;


            while (a > 0 )
            {
                long temp = a % 10;
                if (temp % 2 == 0)
                {
                    even += temp;
                }
                else
                {
                    odd += temp;
                }

                a = a/10;
               
            }

            if (even > odd)
            {
                Console.WriteLine("right {0}",even);
            }
            else if (even < odd)
            {
                Console.WriteLine("left {0}", odd);
            }
            else
            {
                Console.WriteLine("straight {0}", even);
            }
        }
    }
}
