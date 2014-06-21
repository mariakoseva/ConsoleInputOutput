using System;


namespace NumbersFromOneToN
{
    class NumbersFromOneToN
    {
        static void Main()
        {
            Console.WriteLine("The program writes the numbers from 1 do N on the console");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <=n ; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
