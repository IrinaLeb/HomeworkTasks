// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();
Console.Write("Введите № четверти: ");
int N = int.Parse(Console.ReadLine()!);

while (N < 1 || N > 4)
{
    Console.WriteLine("Введите № четверти от 1 до 4");
    N = int.Parse(Console.ReadLine()!);
}

if (N == 1)
{
    Console.Write("X > 0, Y > 0");
}
else if (N == 2)
{
     Console.Write("X < 0, Y > 0");
}
else if (N == 3)
{
     Console.Write("X < 0, Y < 0");
}
else if (N == 4)
{
     Console.Write("X > 0, Y < 0");
}
