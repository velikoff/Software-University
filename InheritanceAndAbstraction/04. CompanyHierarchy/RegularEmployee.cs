using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04.CompanyHierarchy.Enum;

namespace _04.CompanyHierarchy
{
      public abstract class RegularEmployee : Employee
    {
        protected RegularEmployee(string firstName, string lastName, string id, decimal salary, Department department)
            : base(firstName, lastName, id, salary, department)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
