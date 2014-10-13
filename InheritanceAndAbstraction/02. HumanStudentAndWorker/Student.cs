using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HumanStudentAndWorker
{
    class Student : Human
    {
        public string FacultyNumber { get; set; }

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            return string.Format(
                "{0} {1}, faculty number: {2}", this.FirstName, this.LastName, this.FacultyNumber);
        }
    }
}
