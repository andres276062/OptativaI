using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Smallest of Five");

        double[] numeros = new double[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Ingresa el {i + 1}° número: ");
            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                numeros[i] = numero;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debes ingresar un número.");
                return; // Sale del programa si la entrada no es válida.
            }
        }

        double menor = numeros[0];

        for (int i = 1; i < 5; i++)
        {
            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }

        Console.WriteLine($"Resultado: {menor}");
    }
}
