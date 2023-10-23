using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Remainder Finder");
        
        // Solicita al usuario dos números
        Console.Write("Ingresa el primer número: ");
        if (int.TryParse(Console.ReadLine(), out int numero1))
        {
            Console.Write("Ingresa el segundo número: ");
            if (int.TryParse(Console.ReadLine(), out int numero2))
            {
                // Calcula el residuo de la división
                int residuo = numero1 % numero2;
                
                Console.WriteLine($"Resultado: {residuo}");
            }
            else
            {
                Console.WriteLine("El segundo número ingresado no es válido. Debe ser un número entero.");
            }
        }
        else
        {
            Console.WriteLine("El primer número ingresado no es válido. Debe ser un número entero.");
        }
    }
}

