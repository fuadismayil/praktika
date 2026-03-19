using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskinterfaces.Interfaces;

namespace taskinterfaces.Models
{
    internal class Circle: IShape
    {
        public double Radius { get; set; }
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        double IShape.GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}