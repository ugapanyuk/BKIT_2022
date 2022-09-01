using System;
using System.Collections.Generic;

namespace SquareRoot
{
    /// <summary>
    /// Простое вычисление корней
    /// </summary>
    class SquareRoot_Simple
    {
        /// <summary>
        /// Вычисление корней
        /// </summary>
        public List<double> CalculateRoots(double a, double b, double c)
        {
            List<double> roots = new List<double>();
            double D = b * b - 4 * a * c;
            //Один корень
            if (D == 0)
            {
                double root = -b / (2 * a);
                roots.Add(root);
            }
            //Два корня
            else if (D > 0)
            {
                double sqrtD = Math.Sqrt(D);
                double root1 = (-b + sqrtD) / (2 * a);
                double root2 = (-b - sqrtD) / (2 * a);
                roots.Add(root1);
                roots.Add(root2);
            }
            return roots;
        }

        /// <summary>
        /// Вывод корней
        /// </summary>
        public void PrintRoots(double a, double b, double c)
        {
            List<double> roots = this.CalculateRoots(a, b, c);
            Console.Write("Коэффициенты: a={0}, b={1}, c={2}. ", a, b, c);
            if(roots.Count == 0)
            {
                Console.WriteLine("Корней нет.");
            }
            else if (roots.Count == 1)
            {
                Console.WriteLine("Один корень {0}", roots[0]);
            }
            else if (roots.Count == 2)
            {
                Console.WriteLine("Два корня {0} и {1}", roots[0], roots[1]);
            }
        }

    }
}
