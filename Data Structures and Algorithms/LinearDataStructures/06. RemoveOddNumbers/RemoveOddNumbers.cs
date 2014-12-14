using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RemoveOddNumbers
{
    class RemoveOddNumbers
    {
        public static int[] RemoveOddNumbersFromSequence(int[] sequence)
        {
            if (sequence.Length == 0 || sequence == null)
            {
                throw new ArgumentNullException("The sequence can not be empty or null!");
            }
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < sequence.Length; i++)
            {
                if ((sequence[i] % 2 == 0) || sequence[i] == 1)
                {
                    evenNumbers.Add(sequence[i]);
                }
            }
            return evenNumbers.ToArray();
        }
        static void Main(string[] args)
        {
            int[] sequence = new int[]
            {
                4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2
            };
            sequence = RemoveOddNumbersFromSequence(sequence);

            for (int i = 0; i < sequence.Length; i++)
            {
                Console.Write(sequence[i] + " ");
            }
        }
    }
}
