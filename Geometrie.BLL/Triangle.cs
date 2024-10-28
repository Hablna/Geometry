using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.BLL
{
    public class Triangle : Polygone
    {
        public Triangle(Point a, Point b, Point c) 
            : base(a, b, c)
        {
            //lever une exception si les points sont alignés
            if (a.CalculerDistance(b) + b.CalculerDistance(c) <= a.CalculerDistance(c) ||
                a.CalculerDistance(b) + a.CalculerDistance(c) <= b.CalculerDistance(c) ||
                b.CalculerDistance(c) + a.CalculerDistance(c) <= a.CalculerDistance(b))
            {
                throw new ArgumentException("les points sont alignés");
            }
        }
        public override double CalculerSurface()
        {
            //formule de Heron
            double p = CalculerPerimetre() / 2;
            double a = this[0].CalculerDistance(this[1]);
            double b = this[1].CalculerDistance(this[2]);
            double c = this[2].CalculerDistance(this[0]);
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
