using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfThreeNumbers
{
    class SumofThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("The program calculates the sum of three numbers");
            Console.WriteLine("Please enter number a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number b ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number c ");
            int c = int.Parse(Console.ReadLine());

            int sum = a + b + c;
            Console.WriteLine("The sum of the numbers is : {0}", sum);
        }
    }
}
