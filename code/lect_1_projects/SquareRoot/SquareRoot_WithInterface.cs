using System;
using System.Collections.Generic;

namespace SquareRoot
{
    interface RootsResult { }
    class NoRoots : RootsResult { }
    class OneRoot : RootsResult
    {
        public double root { get; set; }
    }
    class TwoRoots : RootsResult
    {
        public double root1 { get; set; }
        public double root2 { get; set; }
    }

    /// <summary>
    /// Возможные варианты решения расширяются за счет использования интерфейса
    /// </summary>
    class SquareRoot_WithInterface
    {
        /// <summary>
        /// Вычисление корней
        /// </summary>
        public RootsResult CalculateRoots(double a, double b, double c)
        {
            List<double> roots = new List<double>();
            double D = b * b - 4 * a * c;
            //Один корень
            if (D == 0)
            {
                double rt = -b / (2 * a);
                return new OneRoot()
                {
                    root = rt
                };
            }
            //Два корня
            else if (D > 0)
            {
                double sqrtD = Math.Sqrt(D);
                double rt1 = (-b + sqrtD) / (2 * a);
                double rt2 = (-b - sqrtD) / (2 * a);
                return new TwoRoots()
                {
                    root1 = rt1,
                    root2 = rt2
                };
            }
            //Нет корней
            else
            {
                return new NoRoots();
            }
        }

        /// <summary>
        /// Вывод корней
        /// </summary>
        public void PrintRoots(double a, double b, double c)
        {
            RootsResult result = this.CalculateRoots(a, b, c);
            Console.Write("Коэффициенты: a={0}, b={1}, c={2}. ", a, b, c);
            string resultType = result.GetType().Name;
            if (resultType == "NoRoots")
            {
                Console.WriteLine("Корней нет.");
            }
            else if (resultType == "OneRoot")
            {
                OneRoot rt1 = (OneRoot)result;
                Console.WriteLine("Один корень {0}", rt1.root);
            }
            else if (resultType == "TwoRoots")
            {
                TwoRoots rt2 = (TwoRoots)result;
                Console.WriteLine("Два корня {0} и {1}", rt2.root1, rt2.root2);
            }
        }

    }
}
