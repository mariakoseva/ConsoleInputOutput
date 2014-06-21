using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterandArea
{
    class CirclePerimeterandArea
    {
        static void Main()
        {
            Console.WriteLine("Please enter the radius of the circle");
            double radius = double.Parse(Console.ReadLine());
            double Pi = Math.PI;

            double perimeter = 2 * Pi * radius;
            double area = Pi * radius * radius;
            Console.WriteLine("The are of the circle is {0:F2}", area);
            Console.WriteLine("The perimeter of the circle is: {0:F2}", perimeter);
        }
    }
}
