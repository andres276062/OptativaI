using System;

class Program
{
    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Menú de Ejercicios:");
            Console.WriteLine("1. Positive Power");
            Console.WriteLine("2. Double or Triple");
            Console.WriteLine("3. Root or Square");
            Console.WriteLine("4. Circle Perimeter");
            Console.WriteLine("5. Midweek Day");
            Console.WriteLine("6. Tax Calculator");
            Console.WriteLine("7. Remainder Finder");
            Console.WriteLine("8. Sum of Evens");
            Console.WriteLine("9. Fraction Difference");
            Console.WriteLine("10. String Length");
            Console.WriteLine("11. Average of Four");
            Console.WriteLine("12. Smallest of Five");
            Console.WriteLine("13. Vowel Counter");
            Console.WriteLine("14. Factorial Finder");
            Console.WriteLine("15. InRange Validator");
            Console.WriteLine("0. Salir");
            Console.Write("Selecciona un ejercicio (0 para salir): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        PositivePower.Exercise();
                        break;
                    case 2:
                        DoubleOrTriple.Exercise();
                        break;
                    case 3:
                        RootOrSquare.Exercise();
                        break;
                    case 4:
                        CirclePerimeter.Exercise();
                        break;
                    case 5:
                        MidweekDay.Exercise();
                        break;
                    case 6:
                        TaxCalculator.Exercise();
                        break;
                    case 7:
                        RemainderFinder.Exercise();
                        break;
                    case 8:
                        SumOfEvens.Exercise();
                        break;
                    case 9:
                        FractionDifference.Exercise();
                        break;
                    case 10:
                        StringLength.Exercise();
                        break;
                    case 11:
                        AverageOfFour.Exercise();
                        break;
                    case 12:
                        SmallestOfFive.Exercise();
                        break;
                    case 13:
                        VowelCounter.Exercise();
                        break;
                    case 14:
                        FactorialFinder.Exercise();
                        break;
                    case 15:
                        InRangeValidator.Exercise();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa.");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un número.");
            }
        }
    }

    public class PositivePower
    {
        public static void Exercise()
        {
            Console.Write("Ingrese un número: ");
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                if (number >= 0)
                {
                    double result = Math.Pow(number, 2);
                    Console.WriteLine($"Resultado: {result}");
                }
                else
                {
                    Console.WriteLine("Resultado: Número negativo.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un número.");
            }
        }
    }

    public class DoubleOrTriple
    {
        public static void Exercise()
        {
            Console.Write("Ingrese dos números separados por comas: ");
            string[] inputs = Console.ReadLine().Split(',');
            if (inputs.Length == 2 && double.TryParse(inputs[0], out double num1) && double.TryParse(inputs[1], out double num2))
            {
                if (num1 > num2)
                {
                    double result = num1 * 2;
                    Console.WriteLine($"Resultado: {result}");
                }
                else
                {
                    double result = num2 * 3;
                    Console.WriteLine($"Resultado: {result}");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debe ingresar dos números separados por comas.");
            }
        }
    }

    public class RootOrSquare
    {
        public static void Exercise()
        {
            Console.Write("Ingrese un número: ");
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                if (number >= 0)
                {
                    double result = Math.Sqrt(number);
                    Console.WriteLine($"Resultado: {result}");
                }
                else
                {
                    double result = Math.Pow(number, 2);
                    Console.WriteLine($"Resultado: {result}");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un número.");
            }
        }
    }

    public class CirclePerimeter
    {
        public static void Exercise()
        {
            Console.Write("Ingrese el radio de un círculo: ");
            if (double.TryParse(Console.ReadLine(), out double radius))
            {
                if (radius >= 0)
                {
                    double result = 2 * Math.PI * radius;
                    Console.WriteLine($"Resultado: {result:F2}");
                }
                else
                {
                    Console.WriteLine("Entrada no válida. El radio debe ser no negativo.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un número.");
            }
        }
    }

    public class MidweekDay
    {
        public static void Exercise()
        {
            Console.Write("Ingrese un número entre 1 y 7: ");
            if (int.TryParse(Console.ReadLine(), out int day))
            {
                string[] daysOfWeek = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
                if (day >= 1 && day <= 7)
                {
                    if (day >= 1 && day <= 5)
                    {
                        Console.WriteLine($"Resultado: {daysOfWeek[day - 1]}");
                    }
                    else
                    {
                        Console.WriteLine("Resultado: Número fuera del rango laboral.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. El número debe estar entre 1 y 7.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un número.");
            }
        }
    }

    public class TaxCalculator
    {
        public static void Exercise()
        {
            Console.Write("Ingrese su salario anual: ");
            if (double.TryParse(Console.ReadLine(), out double salary))
            {
                double tax = 0;
                if (salary > 12000)
                {
                    tax = (salary - 12000) * 0.15;
                }
                Console.WriteLine($"Resultado: {tax}");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un número.");
            }
        }
    }

    public class RemainderFinder
    {
        public static void Exercise()
        {
            Console.Write("Ingrese dos números separados por comas: ");
            string[] inputs = Console.ReadLine().Split(',');
            if (inputs.Length == 2 && int.TryParse(inputs[0], out int num1) && int.TryParse(inputs[1], out int num2))
            {
                int result = num1 % num2;
                Console.WriteLine($"Resultado: {result}");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debe ingresar dos números enteros separados por comas.");
            }
        }
    }

    public class SumOfEvens
    {
        public static void Exercise()
        {
            int sum = 0;
            for (int i = 2; i <= 50; i += 2)
            {
                sum += i;
            }
            Console.WriteLine($"Resultado: {sum}");
        }
    }

    public class FractionDifference
    {
        public static void Exercise()
        {
            Console.Write("Ingrese dos fracciones en el formato 'a/b, c/d': ");
            string[] inputs = Console.ReadLine().Split(',');
            if (inputs.Length == 2)
            {
                string[] fractions1 = inputs[0].Split('/');
                string[] fractions2 = inputs[1].Split('/');
                if (fractions1.Length == 2 && fractions2.Length == 2 &&
                    int.TryParse(fractions1[0], out int a) && int.TryParse(fractions1[1], out int b) &&
                    int.TryParse(fractions2[0], out int c) && int.TryParse(fractions2[1], out int d) &&
                    b != 0 && d != 0)
                {
                    int numerator1 = a * d;
                    int numerator2 = c * b;
                    int denominator = b * d;
                    int resultNumerator = numerator1 - numerator2;
                    Console.WriteLine($"Resultado: {resultNumerator}/{denominator}");
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Debe ingresar fracciones válidas.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debe ingresar dos fracciones separadas por una coma.");
            }
        }
    }

    public class StringLength
    {
        public static void Exercise()
        {
            Console.Write("Ingrese una palabra: ");
            string word = Console.ReadLine();
            int length = word.Length;
            Console.WriteLine($"Resultado: {length}");
        }
    }

    public class AverageOfFour
    {
        public static void Exercise()
        {
            Console.Write("Ingrese cuatro números separados por comas: ");
            string[] inputs = Console.ReadLine().Split(',');
            if (inputs.Length == 4 && double.TryParse(inputs[0], out double num1) &&
                double.TryParse(inputs[1], out double num2) &&
                double.TryParse(inputs[2], out double num3) &&
                double.TryParse(inputs[3], out double num4))
            {
                double average = (num1 + num2 + num3 + num4) / 4;
                Console.WriteLine($"Resultado: {average}");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debe ingresar cuatro números separados por comas.");
            }
        }
    }

    public class SmallestOfFive
    {
        public static void Exercise()
        {
            Console.Write("Ingrese cinco números separados por comas: ");
            string[] inputs = Console.ReadLine().Split(',');
            if (inputs.Length == 5 && double.TryParse(inputs[0], out double num1) &&
                double.TryParse(inputs[1], out double num2) &&
                double.TryParse(inputs[2], out double num3) &&
                double.TryParse(inputs[3], out double num4) &&
                double.TryParse(inputs[4], out double num5))
            {
                double min = Math.Min(Math.Min(Math.Min(Math.Min(num1, num2), num3), num4), num5);
                Console.WriteLine($"Resultado: {min}");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debe ingresar cinco números separados por comas.");
            }
        }
    }

    public class VowelCounter
    {
        public static void Exercise()
        {
            Console.Write("Ingrese una palabra: ");
            string word = Console.ReadLine().ToLower();
            int vowelCount = 0;
            foreach (char c in word)
            {
                if ("aeiou".Contains(c))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine($"Resultado: {vowelCount}");
        }
    }

    public class FactorialFinder
    {
        public static void Exercise()
        {
            Console.Write("Ingrese un número: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number >= 0)
                {
                    int factorial = 1;
                    for (int i = 2; i <= number; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine($"Resultado: {factorial}");
                }
                else
                {
                    Console.WriteLine("Resultado: Número negativo. Debe ingresar un número no negativo.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
            }
        }
    }

    public class InRangeValidator
    {
        public static void Exercise()
        {
            Console.Write("Ingrese un número: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number >= 10 && number <= 20)
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
                Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
            }
        }
    }
}
