using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter integer number: ");
                int input = int.Parse(Console.ReadLine());
                if (input < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                double sqrt = Math.Sqrt(input);
                Console.WriteLine("Square root of the number is: {0}", sqrt);
            }
            catch (ArgumentOutOfRangeException)
            {

                Console.WriteLine("Number should be positive");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}
