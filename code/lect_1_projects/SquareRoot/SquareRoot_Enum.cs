using System;
using System.Collections.Generic;

namespace SquareRoot
{
    /// <summary>
    /// Перечисление для обозначения количества корней
    /// </summary>
    enum RootsEnum { NoRoots, OneRoot, TwoRoots }

    /// <summary>
    /// Вычисление корней с использованием перечисления
    /// </summary>
    class SquareRoot_Enum
    {
        /// <summary>
        /// Вычисление корней
        /// </summary>
        public void CalculateRoots(double a, double b, double c, out List<double> roots, out RootsEnum rootFlag)
        {
            rootFlag = RootsEnum.NoRoots;
            roots = new List<double>();
            double D = b * b - 4 * a * c;
            //Один корень
            if (D == 0)
            {
                rootFlag = RootsEnum.OneRoot;
                double root = -b / (2 * a);
                roots.Add(root);
            }
            //Два корня
            else if (D > 0)
            {
                rootFlag = RootsEnum.TwoRoots;
                double sqrtD = Math.Sqrt(D);
                double root1 = (-b + sqrtD) / (2 * a);
                double root2 = (-b - sqrtD) / (2 * a);
                roots.Add(root1);
                roots.Add(root2);
            }
        }

        /// <summary>
        /// Вывод корней
        /// </summary>
        public void PrintRoots(double a, double b, double c)
        {
            List<double> roots;
            RootsEnum rootFlag;
            this.CalculateRoots(a, b, c, out roots, out rootFlag);
            Console.Write("Коэффициенты: a={0}, b={1}, c={2}. ", a, b, c);
            if (rootFlag == RootsEnum.NoRoots)
            {
                Console.WriteLine("Корней нет.");
            }
            else if (rootFlag == RootsEnum.OneRoot)
            {
                Console.WriteLine("Один корень {0}", roots[0]);
            }
            else if (rootFlag == RootsEnum.TwoRoots)
            {
                Console.WriteLine("Два корня {0} и {1}", roots[0], roots[1]);
            }
        }

    }
}
