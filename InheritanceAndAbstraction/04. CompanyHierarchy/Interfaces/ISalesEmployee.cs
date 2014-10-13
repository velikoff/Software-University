using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompanyHierarchy.Interfaces
{
   public interface ISalesEmployee
    {
        IList<Sale> Sales { get; set; }
    }
}
