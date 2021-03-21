using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionTP2
{
    class Generador
    {
        public static List<double> GenerarNormal(int n, double m, double s)
        {
            Random r = new Random();
            double PI = Math.PI;

            List<double> lst = new List<double>();

            while (lst.Count < n)
            {
                double u = r.NextDouble();
                double v = r.NextDouble();

                double n1 = (Math.Sqrt(-2 * Math.Log(u)) * Math.Cos(2 * PI * v)) * s + m;
                double n2 = (Math.Sqrt(-2 * Math.Log(u)) * Math.Sin(2 * PI * v)) * s + m;

                lst.Add(n1);
                lst.Add(n2);
            }

            if (n % 2 == 1)
            {
                lst.RemoveAt(lst.Count - 1);
            }

            return lst;
        }

        public static List<double> GenerarUniforme(int n, double a, double b)
        {
            Random r = new Random();

            List<double> lst = new List<double>();

            while (lst.Count < n)
            {
                double x = a + r.NextDouble() * (b - a);

                lst.Add(x);
            }

            return lst;
        }

        public static List<double> GenerarExponencial(int n, double l)
        {
            Random r = new Random();

            List<double> lst = new List<double>();

            while (lst.Count < n)
            {
                double u = r.NextDouble();

                double x = (-1 / l) * Math.Log(1 - u);

                lst.Add(x);
            }

            return lst;
        }

        public static List<double> GenerarPoisson(int n, double l)
        {
            Random r = new Random();
            double E = Math.E;

            List<double> lst = new List<double>();
            double a = Math.Pow(E, -l);

            while (lst.Count < n)
            { 
                double p = 1;
                int x = -1;

                do
                {
                    p *= r.NextDouble();
                    x++;
                } while (p >= a);
                lst.Add(x);
            }

            return lst;
        }
    }
}
