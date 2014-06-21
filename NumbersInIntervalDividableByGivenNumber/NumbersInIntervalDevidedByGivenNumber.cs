using System;


class NumbersDividableGivenNumber
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b= int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
                count++;
            Console.WriteLine(count);
        }

        Console.WriteLine(count);
    }
}