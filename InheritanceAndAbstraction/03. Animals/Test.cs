using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Test
    {
        static void Main(string[] args)
        {
            Animal mayaFrog = new Frog("Maya", 2, Genders.Male);
            Animal stoilFrog = new Frog("Stoil", 2, Genders.Male);

            Animal brusDog = new Dog("Brus", 7, Genders.Male);
            Animal saraDog = new Dog("Sara", 6, Genders.Female);

            Animal kotiCat = new Kitten("Koti", 1);
            Animal kotioCat = new Tomcat("Kotio", 5);
            Animal garfieldCat = new Cat("Garfield", 4, Genders.Male);

            List<Animal> animals = new List<Animal>()
            {
                mayaFrog,
                stoilFrog,
                brusDog,
                saraDog,
                kotiCat,
                kotioCat,
                garfieldCat
            };

             var averageAge =
                from animal in animals
                group animal by animal.GetType() into f
                select new { GroupName = f.Key.Name, AverageAge = f.Average(m => m.Age) };

            averageAge.ToList().ForEach(m => Console.WriteLine(m.GroupName + " --> " + m.AverageAge));

        }
    }
}
