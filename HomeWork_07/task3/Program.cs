// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем произвольный массив чисел
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayReversed(array, array.Length - 1);

        Console.ReadLine();
    }

    static void PrintArrayReversed(int[] array, int index)
    {
        // Базовый случай: если индекс меньше 0, то рекурсия завершается
        if (index < 0)
            return;

        // Рекурсивный вызов: выводим текущий элемент массива и уменьшаем индекс на 1
        Console.WriteLine(array[index]);

        PrintArrayReversed(array, index - 1);
    }
}