using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04.CompanyHierarchy.Enum;

namespace _04.CompanyHierarchy.Interfaces
{
    interface IEmployee
    {
        decimal Salary { get; set; }
        Department Department { get; set; }
    }
}
