using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sum of Evens");

        int sumaPares = 0;

        for (int i = 2; i <= 50; i += 2)
        {
            sumaPares += i;
        }

        Console.WriteLine($"Resultado: {sumaPares}");
    }
}

