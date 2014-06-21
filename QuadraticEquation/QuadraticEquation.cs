using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Pleace enter the coefficients a,b and c of the quadratic equation");
            Console.WriteLine("Enter number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number c: ");
            int c = int.Parse(Console.ReadLine());

            double D = (b * b - 4 * a * c);
            if (D <= 0)
            {
                Console.WriteLine("There is no real roots of the equation");
            }
            else if (D == 0)
            {
                Console.WriteLine("There is only one real root of the equation");
                int x1 = -b / (2 * a);
                Console.WriteLine("The root of the equation x = {0}", x1);
            }
            else
            {
                double discriminant = Math.Sqrt(D);
                double rootOne = (-b - discriminant) / (2 * a);
                double rootTwo = (-b + discriminant) / (2 * a);
                Console.WriteLine("The first root of the quadratic equation x1 = {0} ", rootOne);
                Console.WriteLine("The first root of the quadratic equation x2 = {0} ", rootTwo);
            }

        }
    }
}
