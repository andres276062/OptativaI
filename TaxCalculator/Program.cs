using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tax Calculator");
        
        // Solicita al usuario su salario anual
        Console.Write("Ingresa tu salario anual: ");
        if (double.TryParse(Console.ReadLine(), out double salarioAnual))
        {
            double impuesto = 0;
            
            if (salarioAnual > 12000)
            {
                // Calcula el impuesto como el 15% del excedente sobre 12000
                impuesto = (salarioAnual - 12000) * 0.15;
            }

            if (impuesto > 0)
            {
                Console.WriteLine($"Resultado: {impuesto:F2}");
            }
            else
            {
                Console.WriteLine("Resultado: No debe impuestos.");
            }
        }
        else
        {
            Console.WriteLine("El valor ingresado no es válido. Debes ingresar un número.");
        }
    }
}
