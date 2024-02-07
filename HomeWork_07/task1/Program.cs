// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Натуральные числа в промежутке от {0} до {1}:", m, n);
        PrintNumbers(m, n);

        Console.ReadLine();
    }

    static void PrintNumbers(int m, int n)
    {
        // Базовый случай: если m больше n, то рекурсия завершается
        if (m > n)
            return;

        // Рекурсивный вызов: выводим текущее значение m и увеличиваем на 1
        Console.WriteLine(m);

        PrintNumbers(m + 1, n);
    }
}
