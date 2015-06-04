using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WorkDays
{
    class WorkDays
    {
        static readonly DateTime[] holidays =
	{
        // Holidays dates
		new DateTime(2015, 1, 1), new DateTime(2015, 3, 3), new DateTime(2015, 4, 10),
		new DateTime(2015, 4, 13), new DateTime(2015, 5, 1), new DateTime(2015, 5, 6),
		new DateTime(2015, 5, 24), new DateTime(2015, 9, 6), new DateTime(2015, 9, 22),
		new DateTime(2015, 12, 24), new DateTime(2015, 12, 25)
	};

        static void Main()
        {
            DateTime dateNow = DateTime.Now;
            Console.WriteLine("Enter a date between {0:dd.MM.yyyy} and 31.12.2015 in format dd.MM.yyyy: ", dateNow);            
          
            int[] futureDateInput = Console.ReadLine().Split('.').Select(int.Parse).ToArray();
            DateTime futureDate = new DateTime(futureDateInput[2], futureDateInput[1], futureDateInput[0]);
            if (futureDate < dateNow)
            {
                Console.WriteLine("Date you entered is invalid. Please enter new date.");
                Main();
            }
          
            Console.WriteLine("\nTotal workdays: {0}", CheckWorkingDays(dateNow, futureDate));
        }

        private static int CheckWorkingDays(DateTime dateNow, DateTime futureDate)
        {
            int count = 0;
            
            while (dateNow <= futureDate)
            {
                if (!holidays.Contains(dateNow) && dateNow.DayOfWeek != DayOfWeek.Saturday && dateNow.DayOfWeek != DayOfWeek.Sunday)
                {
                    count++;
                }
                dateNow = dateNow.AddDays(1);
            }
            return count;
        }
    }
}
