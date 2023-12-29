//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Enter a number: ");
int i;
int.TryParse(Console.ReadLine(), out i);
Console.Write((i % 23 == 0) && (i % 7 == 0) ? "кратно" : "не кратно");