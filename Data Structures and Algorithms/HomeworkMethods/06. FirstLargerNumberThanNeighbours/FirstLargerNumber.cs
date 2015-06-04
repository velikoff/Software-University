using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace alabala
{
    public class FirstLargerNumber
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 5, 7, 1, 3, 21, 23, 1, 3, 51 };
            Console.WriteLine("Index of the first element in the array that is larger than it neigbours is {0}", firstLargerNumber(array));

        }

        public static int firstLargerNumber(int[] array)
        {
            int index = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                // using method from the previous task
                if (LargerThanNeighbours.largerNumber(array, i))
                {
                    index = i;
                    break;
                }                         
            }
            return index;
        }
    }
}
