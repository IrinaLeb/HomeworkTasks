﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();

Console.WriteLine("Введите трёхзначное число");
int N = int.Parse(Console.ReadLine()!);

if (N > 999 || N < 100)
{
    Console.Write("Ошибка, введите число от 100 до 999");
}
else
{
    int num = N % 100;
    int num2 = num / 10;
    Console.Write($"{num2}");
}  
