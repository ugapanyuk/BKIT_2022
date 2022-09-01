using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тестовые данные
            //2 корня
            double a1 = 1;
            double b1 = 0;
            double c1 = -4;
            //1 корень
            double a2 = 1;
            double b2 = 0;
            double c2 = 0;
            //нет корней
            double a3 = 1;
            double b3 = 0;
            double c3 = 4;

            Console.WriteLine("Test SquareRoot_Simple");
            SquareRoot_Simple r1 = new SquareRoot_Simple();
            r1.PrintRoots(a1, b1, c1);
            r1.PrintRoots(a2, b2, c2);
            r1.PrintRoots(a3, b3, c3);

            Console.WriteLine("Test SquareRoot_Enum");
            SquareRoot_Enum r2 = new SquareRoot_Enum();
            r2.PrintRoots(a1, b1, c1);
            r2.PrintRoots(a2, b2, c2);
            r2.PrintRoots(a3, b3, c3);

            Console.WriteLine("Test SquareRoot_WithInterface");
            SquareRoot_WithInterface r3 = new SquareRoot_WithInterface();
            r3.PrintRoots(a1, b1, c1);
            r3.PrintRoots(a2, b2, c2);
            r3.PrintRoots(a3, b3, c3);
            

            Console.ReadLine();
        }
    }
}
