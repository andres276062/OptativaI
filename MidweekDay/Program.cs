using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Midweek Day");
        
        // Solicita al usuario un número entre 1 y 7
        Console.Write("Ingresa un número (1 al 7): ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            string diaSemana = "";

            // Verifica si el número está dentro del rango laboral
            if (numero >= 1 && numero <= 5)
            {
                // Mapea el número al día de la semana correspondiente
                switch (numero)
                {
                    case 1:
                        diaSemana = "Lunes";
                        break;
                    case 2:
                        diaSemana = "Martes";
                        break;
                    case 3:
                        diaSemana = "Miércoles";
                        break;
                    case 4:
                        diaSemana = "Jueves";
                        break;
                    case 5:
                        diaSemana = "Viernes";
                        break;
                }
            }
            else
            {
                diaSemana = "Número fuera del rango laboral.";
            }

            Console.WriteLine($"Resultado: {diaSemana}");
        }
        else
        {
            Console.WriteLine("El valor ingresado no es válido. Debes ingresar un número entre 1 y 7.");
        }
    }
}

