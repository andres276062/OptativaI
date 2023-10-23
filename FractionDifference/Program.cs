using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Fraction Difference");

        Console.Write("Ingresa la primera fracción en el formato a/b: ");
        string input1 = Console.ReadLine();
        Console.Write("Ingresa la segunda fracción en el formato a/b: ");
        string input2 = Console.ReadLine();

        if (TryParseFraction(input1, out int numerador1, out int denominador1) &&
            TryParseFraction(input2, out int numerador2, out int denominador2))
        {
            int comunDenominador = denominador1 * denominador2;

            int resultadoNumerador = numerador1 * denominador2 - numerador2 * denominador1;

            // Simplifica la fracción resultado dividiendo numerador y denominador por el máximo común divisor
            int mcd = CalcularMCD(resultadoNumerador, comunDenominador);
            resultadoNumerador /= mcd;
            comunDenominador /= mcd;

            string resultado = $"{resultadoNumerador}/{comunDenominador}";
            Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar fracciones en el formato a/b.");
        }
    }

    static bool TryParseFraction(string input, out int numerador, out int denominador)
    {
        numerador = 0;
        denominador = 1;

        string[] parts = input.Split('/');
        if (parts.Length == 2 && int.TryParse(parts[0], out numerador) && int.TryParse(parts[1], out denominador))
        {
            if (denominador != 0)
            {
                return true;
            }
        }
        return false;
    }

    static int CalcularMCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
