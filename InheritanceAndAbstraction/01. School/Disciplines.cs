using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class Disciplines
    {
        public string Name { get; set; }
        public int NumLectures { get; set; }
        public List<Students> Students  { get; set; }

        public Disciplines(string name, int numLectures, List<Students> students, string details = null )
        {
            this.Name = name;
            this.NumLectures = numLectures;
            this.Students = students;
        }
    }
}
