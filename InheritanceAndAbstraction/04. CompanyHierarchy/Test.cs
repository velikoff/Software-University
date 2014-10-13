using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04.CompanyHierarchy.Enum;

namespace _04.CompanyHierarchy
{
    class Test
    {
        static void Main(string[] args)
        {
            List<Project> tattooProject = new List<Project>()
            {
                new Project("Own Design", new DateTime(2014, 09, 15), "make your own tattoo design", State.Closed),
                new Project("Tattoo Estimate", new DateTime(2014, 09, 11), "get your tattoo estimate", State.Open)
            };

            Employee emo = new Developer("Emil", "Atanasov", "8578787823", 3000, Department.Accounting, tattooProject);
            Employee petko = new Developer("Petko", "Alexandrov", "8578787823", 3000, Department.Marketing, tattooProject);

            List<Sale> sales = new List<Sale>()
            {
                new Sale("Beta Version", new DateTime(2015, 03, 01), 500),
                new Sale("Date Up", new DateTime(2015, 06, 06), 900)
            };

            Employee angel = new SalesEmployee("Angel", "Rosenov", "8578787823", 1400, Department.Production, sales);


            Person plamen = new Manager("Plamen", "Plamenov", "8578787823", 90000, Department.Marketing, new List<Employee>() { emo, angel, petko });

            Console.WriteLine(plamen);

            Person anatoli = new Customer("Anatoli", "Neshev", "8578787823", 900);
            Console.WriteLine();
            Console.WriteLine(anatoli);
        }
    }
}
