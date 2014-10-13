using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04.CompanyHierarchy.Enum;
using _04.CompanyHierarchy.Interfaces;

namespace _04.CompanyHierarchy
{
   public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private IList<Sale> sales;

        public IList<Sale> Sales
        {
            get
            {
                return this.sales;
            }
            set
            {
                if (value.Count < 0)
                {
                    throw new ArgumentException("Sales employee must holds a set of sales.");
                }
                this.sales = value;
            }
        }

        public SalesEmployee(string firstName, string lastName, string id, decimal salary,
            Department department, IList<Sale> sales) 
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public override string ToString()
        {
            string result = String.Format("{0}: {1}, Sales: \n", 
                this.GetType().Name, base.ToString());

            int counter = 1;
            foreach (var sale in this.Sales)
            {
                result += "\n\t" + counter + ". " + sale.ToString();

                counter++;
            }

            return result;
        }
    }
}
