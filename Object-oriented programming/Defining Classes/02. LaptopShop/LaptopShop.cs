using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop sony = new Laptop("Sony Vaio", 1200);
            Console.WriteLine(sony);
            Battery lion = new Battery("Li-Ion, 4-cells, 2550 mAh");
            Battery nicd = new Battery("Ni-Cd", (float)4.5);
            Laptop Lenovo = new Laptop("Lenovo Yoga 2 Pro", 1500, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache", "16 GB", "Intel HD Graphics 4400", "1 TB", "13.3 (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", lion);
            Console.WriteLine(Lenovo);
        }
    }
}
