using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumIntegers
{
    class SumIntegers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int[] numbers = new int[arr.Length];
            int sum = 0;

            for (int i = 0; i < arr.Length;i++)
            {
                numbers[i] = int.Parse(arr[i]);
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
