using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("String Length");

        Console.Write("Ingresa una palabra: ");
        string palabra = Console.ReadLine();

        int longitud = palabra.Length;

        Console.WriteLine($"Resultado: {longitud}");
    }
}
