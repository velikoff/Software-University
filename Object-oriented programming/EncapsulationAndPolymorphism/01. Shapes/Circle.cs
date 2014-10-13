﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Circle : BasicShape
    {
          public Circle(double width)
            : base(width, width)
        {
        }

        public override double CalculateArea()
        {
            return Math.PI * this.Width * this.Width / 4;
        }

        public override double CalculatePerimeter()
        {
            return Math.PI * 2 * this.Width / 2;
        }
    }
}
