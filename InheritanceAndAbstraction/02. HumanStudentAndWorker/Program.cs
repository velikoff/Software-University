using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02.HumanStudentAndWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker vladWorker = new Worker("Vlado", "Peshev", 213m, 7f);
            Worker nedkoWorker = new Worker("Nedko", "Minchev", 303m, 8f);
            Worker markoWorker = new Worker("Marko", "Straja", 193m, 5f);
            Worker danchoWorker = new Worker("Dancho", "Ushev", 282m, 9f);
            Worker ivoWorker = new Worker("Ivo", "Ivanov", 412m, 10f);
            Worker didoWorker = new Worker("Dido", "Ivanov", 323m, 9f);
            Worker petkoWorker = new Worker("Petko", "Aleksandrov", 453m, 11f);
            Worker angelWorker = new Worker("Angel", "Rosenov", 223m, 8f);
            Worker spasWorker = new Worker("Spas", "Enev", 243m, 7f);
            Worker krasiWorker = new Worker("Krasi", "Plachkov", 333m, 9f);

            List<Worker> workers = new List<Worker>()
            {
                vladWorker,
                nedkoWorker,
                markoWorker,
                danchoWorker,
                ivoWorker,
                didoWorker,
                petkoWorker,
                angelWorker,
                spasWorker,
                krasiWorker
            };

            Student johnStudent = new Student("John", "Keisling","63456768");
            Student minchoStudent = new Student("Mincho", "Ivanov","557457465");
            Student rusiStudent= new Student("Rusi", "Rusev","3456768");
            Student jasminaStudent = new Student("Jasmina", "Petkova","6456768");
            Student borkoStudent = new Student("Borko", "Rusev","54743738");
            Student ivanStudent = new Student("Ivan", "Pelovski","35745737");
            Student georgiStudent = new Student("Georgi", "Plamenov","3426347");
            Student mihaelaStudent = new Student("Mihaela", "Panayotova","4366768");
            Student irinaStudent = new Student("Irina", "Marinova","2353634");
            Student steliStudent = new Student("Steliyana", "Rupert","23643457");

            List<Student> students = new List<Student>()
            {
                johnStudent,
                minchoStudent,
                rusiStudent,
                jasminaStudent,
                borkoStudent,
                ivanStudent,
                georgiStudent,
                mihaelaStudent,
                irinaStudent,
                steliStudent
                
            };

            Console.WriteLine("Sorted Students");
            Console.WriteLine("----------------------------------------------------------");

            var sortStudents = students.OrderBy(stud => stud.FacultyNumber);
            int count = 1;
            foreach (var student in sortStudents)
            { 
                Console.WriteLine("{0}. {1}", count, student);
                count++;
            }

            Console.WriteLine();
            Console.WriteLine("Sorted Workers");
            Console.WriteLine("----------------------------------------------------------");
            count = 1;
            var sortWorkers = workers.OrderByDescending(work => work.MoneyPerHour(11));
            foreach (var work in sortWorkers)
            {
                Console.WriteLine(count + ". " + work + string.Format(", payment per hour: {0:N2}", work.MoneyPerHour(11)));
                count++;
            }

            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            Console.WriteLine();
            Console.WriteLine("Sorted Humans");
            Console.WriteLine("----------------------------------------------------------");
            var sortHumans = humans.OrderBy(f => f.FirstName).ThenBy(l => l.LastName);
            count = 1;
            foreach (var human in sortHumans)
            {
                Console.WriteLine(count + ". " + human);
                count++;
            }

        }
    }
}
