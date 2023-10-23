using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("InRange Validator");

        Console.Write("Ingresa un número: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero >= 10 && numero <= 20)
            {
                Console.WriteLine("Resultado: Está en el rango.");
            }
            else
            {
                Console.WriteLine("Resultado: Fuera del rango.");
            }
        }
        else
        {
            Console.WriteLine("El valor ingresado no es válido. Debes ingresar un número entero.");
        }
    }
}
