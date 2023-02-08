// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), причем X ≠ 0 и Y ≠ 0
// и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.Clear();

Console.WriteLine("Введите координат X: ");
int X = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координат Y: ");
int Y = int.Parse(Console.ReadLine()!);

if (X > 0 && Y > 0)
{
    Console.WriteLine("Первая четверть");
}
if (X > 0 && Y < 0)
{
    Console.WriteLine("Четвертая четверть");
}
if (X < 0 && Y > 0)
{
    Console.WriteLine("Вторая четверть");
}
if (X < 0 && Y < 0)
{
    Console.WriteLine("Третья четверть");
}