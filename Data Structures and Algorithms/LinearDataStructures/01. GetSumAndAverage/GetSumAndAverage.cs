using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GetSumAndAverage
{
    class GetSumAndAverage
    {
        private static List<int> SaveInput()
        {
            List<int> numbers = new List<int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == String.Empty)
                {
                    break;
                }
                else
                {
                    numbers.Add(int.Parse(input));
                }
            }
            return numbers;
        }
        static void Main(string[] args)
        {
            List<int> numbers = SaveInput();
            Console.WriteLine("Sum = {0}", numbers.Sum());
            Console.WriteLine("Average = {0}", numbers.Average());
        }
    }
}
