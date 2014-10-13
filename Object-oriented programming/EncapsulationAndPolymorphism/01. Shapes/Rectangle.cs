﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double heigth) : base(width, heigth)
        {
            
        }

        public override double CalculateArea()
        {
            return this.Width*this.Height;
        }

        public override double CalculatePerimeter()
        {
            return (this.Width*2) + (this.Height*2);
        }
    }
}
