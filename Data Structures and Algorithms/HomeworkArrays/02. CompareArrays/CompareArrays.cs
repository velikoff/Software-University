using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter first array size: ");
            int firstArraySize = int.Parse(Console.ReadLine());
            Console.Write("Please enter second array size: ");
            int secondArraySize = int.Parse(Console.ReadLine());

            int[] firstArray = new int[firstArraySize];
            int[] secondArray = new int[secondArraySize];
            Console.WriteLine();

            Console.WriteLine("---First array---");
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("Index {0}: ", i);
                firstArray[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();

            Console.WriteLine("---Second array---");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write("Index {0}: ", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }


        }
    }
}
