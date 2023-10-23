using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Double or Triple");
        
        // Solicita al usuario dos números
        Console.Write("Ingresa el primer número: ");
        if (double.TryParse(Console.ReadLine(), out double numero1))
        {
            Console.Write("Ingresa el segundo número: ");
            if (double.TryParse(Console.ReadLine(), out double numero2))
            {
                double resultado;
                
                // Comprueba si el primer número es mayor que el segundo
                if (numero1 > numero2)
                {
                    // Devuelve el doble del primer número
                    resultado = numero1 * 2;
                }
                else
                {
                    // Devuelve el triple del segundo número
                    resultado = numero2 * 3;
                }
                
                Console.WriteLine($"Resultado: {resultado}");
            }
            else
            {
                Console.WriteLine("El segundo número ingresado no es válido.");
            }
        }
        else
        {
            Console.WriteLine("El primer número ingresado no es válido.");
        }
    }
}
