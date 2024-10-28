using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.BLL
{
    public abstract class Polygone : IEnumerable<Point>, IForme
    {
        private ArrayList lesPoints;
        //indexeur
        public Point this[int index]
        {
            get
            {
                return (Point)lesPoints[index];
            }
            set
            {
                lesPoints[index] = value;
            }
        }

        //public int Count
        //{
        //    get
        //    {
        //        return lesPoints.Count;
        //    }
        //}
        public int Count => lesPoints.Count;

        /// <summary>
        /// constructeur d'un polygone
        /// </summary>
        /// <param name="a">premier point </param>
        /// <param name="b">deuxieme point</param>
        /// <param name="c">troisieme point </param>
        /// <param name="autrePoints">autre point </param>
        public Polygone(Point a, Point b, Point c, params Point[] autrePoints) { 
            if (a== null || b==null || c == null)
            {
                throw new ArgumentNullException("il manque un des points");
            }
            if(autrePoints != null && autrePoints.Any(p => p == null))
            {
                throw new ArgumentNullException("un des points est null");
            }

            lesPoints = new ArrayList();
            lesPoints.Add(a);
            lesPoints.Add(b);
            lesPoints.Add(c);
            if (autrePoints != null)
            {
                lesPoints.AddRange(autrePoints);
            }

        }

        public IEnumerator<Point> GetEnumerator()
        {
            foreach (Point p in lesPoints)
            {
                //yield est un mot clé qui permet de retourner un élement à la fois
                yield return p;
            }
  
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); // me permet de concatener
            sb.Append("[");

            foreach (Point p in lesPoints)
            {
                sb.Append(p.ToString());
                sb.Append(" ");
            }
            sb.Append("]");
            return sb.ToString();
        }

        public double CalculerPerimetre()
        {
            double perimetre = 0;
            for (int i = 0; i < Count - 1; i++)
            {
                Point p1 = this[i];
                Point p2 = this[i + 1];
                perimetre += p1.CalculerDistance(p2);
            }
            perimetre += this[Count - 1].CalculerDistance(this[0]);
            return perimetre;
        }
        public abstract double CalculerSurface();

    }
}
