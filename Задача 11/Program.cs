﻿// Задача №11. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// ● 456 -> 46
// ● 782 -> 72
// ● 918 -> 98

Console.Clear();

int num = new Random().Next(100, 1000); // от 100 до 999
{
  Console.WriteLine(num);
}

int a1 = num / 100;
int a2 = num % 10;
int res = a1 * 10 + a2;
{
  Console.WriteLine($"{res}");
}