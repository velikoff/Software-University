using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HumanStudentAndWorker
{
    class Worker : Human
    {
        private decimal weekSalary;
        private float workHoursPerDay;

        public decimal WeekSalary { get; set; }
        public float WorkHoursPerDay { get; set; }

        public Worker (string firstName, string lastName) : base(firstName, lastName)
        {
            
        }

        public Worker(string firstName, string lastName, decimal weekSalary, float workHoursePerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursePerDay;
        }
        

        public decimal MoneyPerHour(int moneyPerHour)
        {
            return this.WeekSalary / (decimal)(this.WorkHoursPerDay*moneyPerHour);
           

        }

        public override string ToString()
        {
            return string.Format(
                "{0} {1}"
                , this.FirstName, this.LastName);
        }
    }
}
