using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetLargestNumber
{
    class LargestNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The larger number of {0} and {1} is {2}", firstNumber, secondNumber,
                getLargestNumber(firstNumber, secondNumber));
            Console.WriteLine("The larger number of {0} and {1} is {2}", secondNumber, thirdNumber,
                getLargestNumber(thirdNumber, secondNumber));
            Console.WriteLine("The larger number of {0} and {1} is {2}", firstNumber, thirdNumber,
                getLargestNumber(firstNumber, thirdNumber));



        }

        private static int getLargestNumber(int a, int b)
        {
            int greaterNumber = a;
            if (a < b)
            {
                greaterNumber = b;
            }
            return greaterNumber;
        }
    }
}
