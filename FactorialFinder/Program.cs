using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Factorial Finder");

        Console.Write("Ingresa un número: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero >= 0)
            {
                long factorial = CalcularFactorial(numero);
                Console.WriteLine($"Resultado: {factorial}");
            }
            else
            {
                Console.WriteLine("El número ingresado debe ser no negativo.");
            }
        }
        else
        {
            Console.WriteLine("El valor ingresado no es válido. Debes ingresar un número entero.");
        }
    }

    static long CalcularFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        long resultado = 1;
        for (int i = 1; i <= n; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
}
