using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace _07.HowManyTimeNumberOccurs
{
    class HowManyTimeNumberOccurs
    {
        public static string[] FindHowManyTimesNumberOccurs(int[] sequence)
        {
            if (sequence.Length == 0 || sequence == null)
            {
                throw new ArgumentNullException("The sequence can not be empty or null!");
            }

            List<string> howManyNumOccurs = new List<string>();
            Array.Sort(sequence);
            
            int occurs = 1;

            for (int i = 0; i < sequence.Length; i+=occurs)
            {
                occurs = 1;
                int number = sequence[i];

                for (int j = i + 1; j < sequence.Length; j++)
                {
                    if (sequence[i] == sequence[j])
                    {
                        occurs +=1;
                    }              
                }
                howManyNumOccurs.Add(String.Format("{0} -> {1} times", number, occurs));
            }
            return howManyNumOccurs.ToArray();
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                3, 4, 4, 2, 3, 3, 4, 3, 2
            };

            string[] numberOccurs = FindHowManyTimesNumberOccurs(numbers);
            foreach (var num in numberOccurs)
            {
                Console.WriteLine(num);
            }
        }
    }
}
