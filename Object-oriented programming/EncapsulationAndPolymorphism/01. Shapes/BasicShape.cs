using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    public abstract class BasicShape : IShape
    {
        private double width;
        private double heigth;

        public double Width { get; set; }
        public double Height { get; set; }

        public BasicShape(double width, double heigth)
        {
            this.Width = width;
            this.Height = heigth;
        }
        public abstract double  CalculateArea();
        public abstract double CalculatePerimeter();

    }
}
