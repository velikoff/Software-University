using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alabala
{
    public class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            
            int[] array = { 1, 2, 5, 7, 1, 3, 21, 23, 1, 3, 51};
            Console.WriteLine(largerNumber(array, 3));
        }

        public static bool largerNumber(int[] array, int index)
        {
            bool isLarger = false;

            if (index == 0 || index == array.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return isLarger;
            }

            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                isLarger = true;
            }
            return isLarger;
        }
    }
}
