using System;
using System.Numerics;

namespace FibbonacciNumbers
{
    class FibbonacciNumbers
    {
        static void Main()
        {
            Console.WriteLine("The program reads the first n numbers from the Fibonacci row");
            int n = int.Parse(Console.ReadLine());

            BigInteger fibonacciFirstNumber = 0;
            BigInteger fibonaccisecondNumber = 1;

            Console.WriteLine(fibonacciFirstNumber);
            Console.WriteLine(fibonaccisecondNumber);
            BigInteger thirdNumber = 0;
            for (int i = 2; i < n; i++)
            {
                thirdNumber = fibonaccisecondNumber + fibonacciFirstNumber;
                Console.WriteLine(thirdNumber + " ");
                fibonacciFirstNumber = fibonaccisecondNumber;
                fibonaccisecondNumber = thirdNumber;
            }
        }
    }
}
