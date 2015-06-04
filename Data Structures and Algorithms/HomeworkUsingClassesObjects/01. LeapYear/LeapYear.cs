using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year,1,1);
            bool isLeapYear = DateTime.IsLeapYear(date.Year);

            if (isLeapYear)
            {
                Console.WriteLine("The year is leap");
            }
            else
            {
                Console.WriteLine("The year is not leap");
            }
            
        }
    }
}
