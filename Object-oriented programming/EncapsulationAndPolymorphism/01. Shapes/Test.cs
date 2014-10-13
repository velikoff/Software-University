using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    internal class Test
    {
        private static void Main(string[] args)
        {
            IShape triangle1 = new Triangle(3, 6.7, 90);
            IShape triangle2 = new Triangle(11.4, 4, 130);

            IShape circle1 = new Circle(6);
            IShape circle2 = new Circle(5.7);
            IShape circle3 = new Circle(5);

            IShape rect1 = new Rectangle(5, 4);
            IShape rect2 = new Rectangle(7, 3);

            IShape[] shapes = new IShape[7] {triangle1, triangle2, rect1, rect2, circle1, circle2, circle3};

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0,-20}: Perimeter: {1:N2}, Area: {2:N2}", shape.GetType().Name,
                    shape.CalculatePerimeter(), shape.CalculateArea());
            }
        }
    }
}
