﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfFiveNumbers
{
    class SumOfFiveNumbers
    {
        static void Main()
        {
            Console.WriteLine("The program calculates the sum of five numbers, please input numbers:");
            string numbers = Console.ReadLine();
            string[] stringnNumbers = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int numberOne = int.Parse(stringnNumbers[0]);
            int numberTwo = int.Parse(stringnNumbers[1]);
            int numberThree = int.Parse(stringnNumbers[2]);
            int numberFour = int.Parse(stringnNumbers[3]);
            int numberFive = int.Parse(stringnNumbers[4]);
            int sum = numberOne + numberTwo + numberThree + numberFour + numberFive;
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}",
stringnNumbers[0], stringnNumbers[1], stringnNumbers[2], stringnNumbers[3], stringnNumbers[4], sum);
        }
    }
}