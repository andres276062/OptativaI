using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Vowel Counter");

        Console.Write("Ingresa una palabra: ");
        string palabra = Console.ReadLine().ToLower(); // Convertir la palabra a minúsculas para facilitar la comparación.

        int contadorVocales = 0;

        foreach (char letra in palabra)
        {
            if ("aeiou".Contains(letra))
            {
                contadorVocales++;
            }
        }

        Console.WriteLine($"Resultado: {contadorVocales}");
    }
}
