using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class Teachers : People
    {
        private List<Disciplines> disciplines; 
        public List<Disciplines> Disciplines { get; set; }

        public Teachers(string name, List<Disciplines> disciplines, string details = null) : base(name, details)
        {
            this.Name = name;
            this.Details = details;
            this.Disciplines = disciplines;
        }


    }
}
