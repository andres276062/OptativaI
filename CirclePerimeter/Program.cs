using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Circle Perimeter");
        
        // Solicita al usuario el radio del círculo
        Console.Write("Ingresa el radio del círculo: ");
        if (double.TryParse(Console.ReadLine(), out double radio))
        {
            // Calcula el perímetro del círculo
            double perimetro = 2 * Math.PI * radio;
            
            Console.WriteLine($"Resultado: {perimetro:F2}");
        }
        else
        {
            Console.WriteLine("El valor ingresado no es válido. Debes ingresar un número.");
        }
    }
}
