using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class Students : People
    {
        public int UniqueNumber { get; set; }
       
        public Students(string name, int uniqueNumber, string details = null) : base(name, details)
        {
            this.UniqueNumber = uniqueNumber;
            
        }
    }
}
