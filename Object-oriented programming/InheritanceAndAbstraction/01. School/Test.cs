using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class Test
    {
        static void Main(string[] args)
        {
              List<Students> studentsList = new List<Students>
            {
                new Students("Ivan", 123456, "some details"),
                new Students("Misha",135463),
                new Students("Silviya",125236),
            };

            var disciplinesList = new List<Disciplines>
            {
                new Disciplines("PHP",135, studentsList, "some details"),
                new Disciplines("KPK", 109, studentsList),
                new Disciplines("JavaScript", 99, studentsList),
            };

            List<Teachers> teachersList = new List<Teachers>
            {
                new Teachers("Mitka", disciplinesList, "some details"),
                new Teachers("Ivana", disciplinesList),
                new Teachers("Milen",disciplinesList),
            };

            Classes firstClass = new Classes("HTML", teachersList, "some details");
        }
    }
}
