using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;

            for (int i = 0; i < 10; i++)
            {
                ReadNumber(start, end);
            }
        }

        static int ReadNumber(int start, int end)
        {
            int number = 0;
            try
            {
                Console.Write("Please enter a number in the range [{0}..{1}]: ", start, end);
                number = int.Parse(Console.ReadLine());
                if (number < start || number > end)
                {
                    while (number < start || number > end)
                    {
                        Console.WriteLine("The number you entered is not in the range [{0}..{1}]", start, end);
                        Console.Write("Please enter new number: ");
                        number = int.Parse(Console.ReadLine());
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number");
                throw;
            }


            return number;
        }
    }
}
