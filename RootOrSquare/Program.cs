using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Root or Square");
        
        // Solicita al usuario un número
        Console.Write("Ingresa un número: ");
        if (double.TryParse(Console.ReadLine(), out double numero))
        {
            double resultado;
            
            // Comprueba si el número es positivo
            if (numero >= 0)
            {
                // Devuelve la raíz cuadrada del número
                resultado = Math.Sqrt(numero);
            }
            else
            {
                // Devuelve el cuadrado del número
                resultado = numero * numero;
            }
            
            Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            Console.WriteLine("El número ingresado no es válido.");
        }
    }
}
