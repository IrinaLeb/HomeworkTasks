// Задача №14. Работа в группах
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// ● 14 -> нет
// ● 46 -> нет
// ● 161 -> да
Console.Clear();

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
int a = 7;
int b = 23;
// int res1 = num % a;
// int res2 = num % b;
// if (res1 == 0 && res2 == 0)
if (num % a == 0 && num % b == 0)
{
    Console.Write("Кратно");
}
else
{
    Console.Write("Не кратно");
}