using System;

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
    Console.WriteLine("16. Salir");
    Console.Write("Elige una opción: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            PositivePower();
            break;
        case "2":
            DoubleOrTriple();
            break;
        case "3":
            RootOrSquare();
            break;
        case "4":
            CirclePerimeter();
            break;
        case "5":
            MidweekDay();
            break;
        case "6":
            TaxCalculator();
            break;
        case "7":
            RemainderFinder();
            break;
        case "8":
            SumOfEvens();
            break;
        case "9":
            FractionDifference();
            break;
        case "10":
            StringLength();
            break;
        case "11":
            AverageOfFour();
            break;
        case "12":
            SmallestOfFive();
            break;
        case "13":
            VowelCounter();
            break;
        case "14":
            FactorialFinder();
            break;
        case "15":
            InRangeValidator();
            break;
        case "16":
            exit = true;
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
            break;
    }
}

void StringLength()
{
    throw new NotImplementedException();
}

// Ejercicio 1
void PositivePower()
{
    Console.Write("Ingresa un número: ");
    double number = Convert.ToDouble(Console.ReadLine());

    if (number >= 0)
    {
        double result = Math.Pow(number, 2);
        Console.WriteLine($"Resultado: {result}");
    }
    else
    {
        Console.WriteLine("Número negativo.");
    }
}

// Ejercicio 2
void DoubleOrTriple()
{
    Console.Write("Ingresa el primer número: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingresa el segundo número: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

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

// Ejercicio 3
void RootOrSquare()
{
    Console.Write("Ingresa un número: ");
    double number = Convert.ToDouble(Console.ReadLine());

    if (number >= 0)
    {
        double result = Math.Sqrt(number);
        Console.WriteLine($"Resultado: {result}");
    }
    else
    {
        double result = number * number;
        Console.WriteLine($"Resultado: {result}");
    }
}

// Ejercicio 4
void CirclePerimeter()
{
    Console.Write("Ingresa el radio del círculo: ");
    double radius = Convert.ToDouble(Console.ReadLine());

    if (radius >= 0)
    {
        double perimeter = 2 * Math.PI * radius;
        Console.WriteLine($"Resultado: {perimeter:F2}");
    }
    else
    {
        Console.WriteLine("Radio no válido.");
    }
}

// Ejercicio 5
void MidweekDay()
{
    Console.Write("Ingresa un número entre 1 y 7: ");
    int day = Convert.ToInt32(Console.ReadLine());

    string[] daysOfWeek = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

    if (day >= 1 && day <= 7)
    {
        if (day >= 1 && day <= 5)
        {
            Console.WriteLine($"Resultado: {daysOfWeek[day - 1]}");
        }
        else
        {
            Console.WriteLine("Número fuera del rango laboral.");
        }
    }
    else
    {
        Console.WriteLine("Número fuera del rango válido.");
    }
}

// Ejercicio 6
void TaxCalculator()
{
    Console.Write("Ingresa tu salario anual: ");
    double annualIncome = Convert.ToDouble(Console.ReadLine());

    if (annualIncome > 12000)
    {
        double tax = 0.15 * (annualIncome - 12000);
        Console.WriteLine($"Impuesto a pagar: {tax:F2}");
    }
    else
    {
        Console.WriteLine("No debe impuestos.");
    }
}

// Ejercicio 7
void RemainderFinder()
{
    Console.Write("Ingresa el primer número: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingresa el segundo número: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num2 != 0)
    {
        int remainder = num1 % num2;
        Console.WriteLine($"Resultado: {remainder}");
    }
    else
    {
        Console.WriteLine("El segundo número no puede ser cero.");
    }
}

// Ejercicio 8
void SumOfEvens()
{
    int sum = 0;

    for (int i = 2; i <= 50; i += 2)
    {
        sum += i;
    }

    Console.WriteLine($"Resultado: {sum}");
}

// Ejercicio 9
void FractionDifference()
{
    Console.Write("Ingresa el numerador de la primera fracción: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingresa el denominador de la primera fracción: ");
    int den1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresa el numerador de la segunda fracción: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingresa el denominador de la segunda fracción: ");
    int den2 = Convert.ToInt32(Console.ReadLine());

    if (den1 != 0 && den2 != 0)
    {
        int commonDenominator = den1 * den2;
        int diffNum = num1 * den2 - num2 * den1;

        Console.WriteLine($"Resultado: {diffNum}/{commonDenominator}");
    }
    else
    {
        Console.WriteLine("Los denominadores no pueden ser cero.");
    }
}


// Ejercicio 11
void AverageOfFour()
{
    double sum = 0;

    for (int i = 1; i <= 4; i++)
    {
        Console.Write($"Ingresa el número {i}: ");
        double num = Convert.ToDouble(Console.ReadLine());
        sum += num;
    }

    double average = sum / 4;
    Console.WriteLine($"Promedio: {average}");
}

// Ejercicio 12
void SmallestOfFive()
{
    int smallest = int.MaxValue;

    for (int i = 1; i <= 5; i++)
    {
        Console.Write($"Ingresa el número {i}: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num < smallest)
        {
            smallest = num;
        }
    }

    Console.WriteLine($"El número más pequeño es: {smallest}");
}

// Ejercicio 13
void VowelCounter()
{
    Console.Write("Ingresa una palabra: ");
    string word = Console.ReadLine();
    int count = 0;

    foreach (char c in word.ToLower())
    {
        if ("aeiou".Contains(c))
        {
            count++;
        }
    }

    Console.WriteLine($"Número de vocales: {count}");
}

// Ejercicio 14
void FactorialFinder()
{
    Console.Write("Ingresa un número: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int factorial = 1;

    if (n >= 0)
    {
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Factorial de {n}: {factorial}");
    }
    else
    {
        Console.WriteLine("El número no puede ser negativo.");
    }
}

// Ejercicio 15
void InRangeValidator()
{
    Console.Write("Ingresa un número: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number >= 10 && number <= 20)
    {
        Console.WriteLine("Está en el rango.");
    }
    else
    {
        Console.WriteLine("Fuera del rango.");
    }
}
