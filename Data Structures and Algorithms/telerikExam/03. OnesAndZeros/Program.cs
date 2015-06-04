using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OnesAndZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            string ones =
@".#.
##.
.#. 
.#.
###";

            string zeros =
@"###
#.#
#.#
#.#
###";

            string dots =
@".
.
.
.
.";

            string input = Console.ReadLine();
            int number = int.Parse(input);
            string binary = Convert.ToString(number, 2);
            binary = binary.PadLeft(16, '0');
            string str010 = ".#.";
            string str110 = "##.";
            string str101 = "#.#";
            string str111 = "###";

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                {
                    Console.Write("{0}{1}", zeros, dots);
                }
                else
                {
                    Console.Write("{0}{1}", ones, dots);
                }
                //Console.Write(dots);
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < binary.Length - 1; j++)
                {
                    if (binary[j] == '0')
                    {
                        Console.Write(str111);
                    }
                    else
                    {
                        Console.Write("{0}{1}", ones, dots);
                    }
                }
            }

        }
    }
}
