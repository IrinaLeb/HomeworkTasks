﻿// Задача №22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4
Console.Clear();

Console.Write("Введите чило: ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
while (i <= N)
{
    //Console.Write($"{i * i} ");
    Console.Write($"{Math.Pow(i, 2)}");
    if (i != N)
    {
        Console.Write(", ");
    }
    i++;
}
