using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheet
{
    class CheatSheet
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int startHor = int.Parse(Console.ReadLine());
            int startVert = int.Parse(Console.ReadLine());

            for (long i = startHor; i < rows + startHor; i++)
            {
                for (long j = startVert; j < cols + startVert; j++)
                {
                    long result = i * j;
                   
                    Console.Write(result + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
