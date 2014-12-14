using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("How much numbers you will use? ");

                string input = Console.ReadLine();
                int amountOfNumbers;
                if (int.TryParse(input, out amountOfNumbers))
                {
                    Console.WriteLine("Enter {0} numbers: ", amountOfNumbers);

                    Stack<int> stack = new Stack<int>();
                    for (int i = 0; i < amountOfNumbers; i++)
                    {
                        int number = 0;
                        string numberAsString = Console.ReadLine();
                        if (int.TryParse(numberAsString, out number))
                        {
                            stack.Push(number);
                        }
                        else
                        {
                            throw new ArgumentException("This is not a number");
                        }
                    }

                    Console.Write("Reversed numbers: ");
                    stack.Reverse();

                    while (stack.Count > 0)
                    {
                        int number = stack.Pop();
                        Console.Write(number + " ");
                    }
                }
                else
                {
                    throw new ArgumentException("This is not a number");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex.Message);
            }

        }
    }
}
