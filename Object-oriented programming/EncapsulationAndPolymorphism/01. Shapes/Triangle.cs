using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Triangle : BasicShape
    {
         private double angle;

        public Triangle(double width, double height, double angle)
            : base(width, height)
        {
            this.Angle =angle;
        }

        public double Angle
        {
            get
            {
                return this.angle;
            }

            set
            {
                if (value < 0 || value > 360)
                {
                    throw new ArgumentOutOfRangeException(
                        "IncludedAngle", "The included angle accepts only values between 0 and 360 degrees");
                }

                this.angle = value;
            }
        }

        public override double CalculateArea()
        {
            return (Math.Sin(this.Angle * Math.PI / 180) * this.Width * this.Height) / 2;
        }

        public override double CalculatePerimeter()
        {
            return this.Width + this.Height + Math.Sqrt((this.Width * this.Width) + (this.Height * this.Height) - (2 * this.Height * this.Width * Math.Cos(this.Angle * Math.PI / 180)));
        }
    }
}
