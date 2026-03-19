using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskinterfaces.Interfaces;

namespace taskinterfaces.Models
{
    public class Rectangle: IShape
    {
        public double A { get; set; }
        public double B { get; set; }

        public Rectangle(double A, double B)
        {
            this.A = A;
            this.B = B;
        }
        public double GetArea()
        {
            return A*B;
        }
    }
}