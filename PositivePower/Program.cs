using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Positive Power");
        Console.Write("Ingresa un número: ");
        string userInput = Console.ReadLine();

        if (double.TryParse(userInput, out double number))
        {
            if (number >= 0)
            {
                double result = Math.Pow(number, 2);
                Console.WriteLine($"Resultado: {result}");
            }
            else
            {
                Console.WriteLine("Resultado: Número negativo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número válido.");
        }
    }
}
