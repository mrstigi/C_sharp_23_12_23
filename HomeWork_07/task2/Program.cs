// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());

        int result = AckermannFunction(m, n);

        Console.WriteLine("Результат вычисления функции Аккермана для чисел {0} и {1}: {2}", m, n, result);

        Console.ReadLine();
    }

    static int AckermannFunction(int m, int n)
    {
        // Базовые случаи
        if (m == 0)
            return n + 1;

        if (m > 0 && n == 0)
            return AckermannFunction(m - 1, 1);

        // Рекурсивный случай
        if (m > 0 && n > 0)
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));

        return 0; // Недостижимый код
    }
}