using System;

public class Ejercicios
{
    public static void PositivePowerExercise()
    {
        Console.Write("Ingresa un número: ");
        if (double.TryParse(Console.ReadLine(), out double number))
        {
            if (number > 0)
            {
                double result = number * number;
                Console.WriteLine("Resultado: " + result);
            }
            else if (number < 0)
            {
                Console.WriteLine("Resultado: Número negativo.");
            }
            else
            {
                Console.WriteLine("Resultado: 0");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número.");
        }
    }

    public static void DoubleOrTripleExercise()
    {
        Console.Write("Ingresa el primer número: ");
        if (double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.Write("Ingresa el segundo número: ");
            if (double.TryParse(Console.ReadLine(), out double num2))
            {
                double result = (num1 > num2) ? num1 * 2 : num2 * 3;
                Console.WriteLine("Resultado: " + result);
            }
            else
            {
                Console.WriteLine("Entrada no válida para el segundo número.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida para el primer número.");
        }
    }

    public static void RootOrSquareExercise()
    {
        Console.Write("Ingresa un número: ");
        if (double.TryParse(Console.ReadLine(), out double number))
        {
            if (number > 0)
            {
                double result = Math.Sqrt(number);
                Console.WriteLine("Resultado: " + result);
            }
            else
            {
                double result = number * number;
                Console.WriteLine("Resultado: " + result);
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número.");
        }
    }

    public static void CirclePerimeterExercise()
    {
        Console.Write("Ingresa el radio de un círculo: ");
        if (double.TryParse(Console.ReadLine(), out double radius))
        {
            double result = 2 * Math.PI * radius;
            Console.WriteLine("Resultado: " + result.ToString("F2"));
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número.");
        }
    }

    public static void MidweekDayExercise()
    {
        Console.Write("Ingresa un número entre 1 y 7: ");
        if (int.TryParse(Console.ReadLine(), out int day))
        {
            switch (day)
            {
                case 1:
                    Console.WriteLine("Resultado: Lunes");
                    break;
                case 2:
                    Console.WriteLine("Resultado: Martes");
                    break;
                case 3:
                    Console.WriteLine("Resultado: Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Resultado: Jueves");
                    break;
                case 5:
                    Console.WriteLine("Resultado: Viernes");
                    break;
                case 6:
                    Console.WriteLine("Resultado: Sábado");
                    break;
                case 7:
                    Console.WriteLine("Resultado: Domingo");
                    break;
                default:
                    Console.WriteLine("Resultado: Número fuera del rango laboral.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número.");
        }
    }

    public static void TaxCalculatorExercise()
    {
        Console.Write("Ingresa tu salario anual: ");
        if (double.TryParse(Console.ReadLine(), out double salary))
        {
            if (salary > 12000)
            {
                double tax = 0.15 * (salary - 12000);
                Console.WriteLine("Resultado: " + tax);
            }
            else
            {
                Console.WriteLine("Resultado: No debe impuestos.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número.");
        }
    }

    public static void RemainderFinderExercise()
    {
        Console.Write("Ingresa el primer número: ");
        if (int.TryParse(Console.ReadLine(), out int num1))
        {
            Console.Write("Ingresa el segundo número: ");
            if (int.TryParse(Console.ReadLine(), out int num2))
            {
                if (num2 != 0)
                {
                    int result = num1 % num2;
                    Console.WriteLine("Resultado: " + result);
                }
                else
                {
                    Console.WriteLine("No puedes dividir por cero.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida para el segundo número.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida para el primer número.");
        }
    }

    public static void SumOfEvensExercise()
    {
        int sum = 0;
        for (int i = 2; i <= 50; i += 2)
        {
            sum += i;
        }
        Console.WriteLine("Resultado: " + sum);
    }

    public static void FractionDifferenceExercise()
    {
        Console.Write("Ingresa el numerador de la primera fracción: ");
        if (int.TryParse(Console.ReadLine(), out int num1))
        {
            Console.Write("Ingresa el denominador de la primera fracción: ");
            if (int.TryParse(Console.ReadLine(), out int denom1) && denom1 != 0)
            {
                Console.Write("Ingresa el numerador de la segunda fracción: ");
                if (int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.Write("Ingresa el denominador de la segunda fracción: ");
                    if (int.TryParse(Console.ReadLine(), out int denom2) && denom2 != 0)
                    {
                        int resultNum = num1 * denom2 - num2 * denom1;
                        int resultDenom = denom1 * denom2;
                        SimplifyFraction(ref resultNum, ref resultDenom);
                        Console.WriteLine("Resultado: " + resultNum + "/" + resultDenom);
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida para el denominador de la segunda fracción.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida para el numerador de la segunda fracción.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida para el denominador de la primera fracción.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida para el numerador de la primera fracción.");
        }
    }

    public static void StringLengthExercise()
    {
        Console.Write("Ingresa una palabra: ");
        string word = Console.ReadLine();
        int length = word.Length;
        Console.WriteLine("Resultado: " + length);
    }

    public static void AverageOfFourExercise()
    {
        double sum = 0;
        for (int i = 1; i <= 4; i++)
        {
            Console.Write("Ingresa el número " + i + ": ");
            if (double.TryParse(Console.ReadLine(), out double num))
            {
                sum += num;
            }
            else
            {
                Console.WriteLine("Entrada no válida para el número " + i + ". Debes ingresar un número.");
                return;
            }
        }
        double average = sum / 4;
        Console.WriteLine("Resultado: " + average);
    }

    public static void SmallestOfFiveExercise()
    {
        double smallest = double.MaxValue;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Ingresa el número " + i + ": ");
            if (double.TryParse(Console.ReadLine(), out double num))
            {
                if (num < smallest)
                {
                    smallest = num;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida para el número " + i + ". Debes ingresar un número.");
                return;
            }
        }
        Console.WriteLine("Resultado: " + smallest);
    }

    public static void VowelCounterExercise()
    {
        Console.Write("Ingresa una palabra: ");
        string word = Console.ReadLine();
        int vowelCount = CountVowels(word);
        Console.WriteLine("Resultado: " + vowelCount);
    }

    public static int CountVowels(string text)
    {
        string vowels = "aeiouAEIOU";
        int count = 0;
        foreach (char c in text)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }
        return count;
    }

    public static void FactorialFinderExercise()
    {
        Console.Write("Ingresa un número: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            if (n >= 0)
            {
                int result = CalculateFactorial(n);
                Console.WriteLine("Resultado: " + result);
            }
            else
            {
                Console.WriteLine("Resultado: El número debe ser no negativo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
        }
    }

    public static int CalculateFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * CalculateFactorial(n - 1);
    }

    public static void InRangeValidatorExercise()
    {
        Console.Write("Ingresa un número: ");
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
            Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
        }
    }

    static void SimplifyFraction(ref int num, ref int denom)
    {
        int gcd = GCD(num, denom);
        num /= gcd;
        denom /= gcd;
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
