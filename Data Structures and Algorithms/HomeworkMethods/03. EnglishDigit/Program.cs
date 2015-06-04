﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer number: ");
            int input = int.Parse(Console.ReadLine());
            Console.Write("Last digit of the number is ");
            lastDigitAsWord(input);
        }

        public static void lastDigitAsWord(int a)
        {
            int lastDigit = a%10;
            
            switch (lastDigit)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                default: 
                    break;
            }
            
        }
    }
}