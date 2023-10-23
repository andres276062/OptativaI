using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Average of Four");

        // Solicita al usuario cuatro números
        Console.Write("Ingresa el primer número: ");
        if (double.TryParse(Console.ReadLine(), out double numero1))
        {
            Console.Write("Ingresa el segundo número: ");
            if (double.TryParse(Console.ReadLine(), out double numero2))
            {
                Console.Write("Ingresa el tercer número: ");
                if (double.TryParse(Console.ReadLine(), out double numero3))
                {
                    Console.Write("Ingresa el cuarto número: ");
                    if (double.TryParse(Console.ReadLine(), out double numero4))
                    {
                        // Calcula el promedio de los cuatro números
                        double promedio = (numero1 + numero2 + numero3 + numero4) / 4;

                        Console.WriteLine($"Resultado: {promedio:F2}");
                    }
                    else
                    {
                        Console.WriteLine("El cuarto número ingresado no es válido. Debe ser un número.");
                    }
                }
                else
                {
                    Console.WriteLine("El tercer número ingresado no es válido. Debe ser un número.");
                }
            }
            else
            {
                Console.WriteLine("El segundo número ingresado no es válido. Debe ser un número.");
            }
        }
        else
        {
            Console.WriteLine("El primer número ingresado no es válido. Debe ser un número.");
        }
    }
}

