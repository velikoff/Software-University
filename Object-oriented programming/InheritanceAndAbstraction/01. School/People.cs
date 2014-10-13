using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public abstract class People
    {
        public string Name { get; set; }
        public string Details { get; set; }

        public People(string name, string details = null)
        {
            this.Name = name;
            this.Details = details;
        }
    }
}
