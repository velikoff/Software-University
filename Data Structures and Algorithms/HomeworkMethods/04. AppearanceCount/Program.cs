using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AppearanceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2 ,3 ,4, 5 ,6, 7, 8, 9, 12, 1, 2, 3, 5, 7};
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int count = countOccurenceInArray(array, number);
            Console.WriteLine("Number {0} appears {1} times in the array ", number, count);
        }

        private static int countOccurenceInArray(int[] array, int number)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
