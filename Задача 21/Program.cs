// Задача №21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21
Console.Clear();

Console.Write("Введите Хa: ");
int Xa = int.Parse(Console.ReadLine()!);
Console.Write("Введите Хb: ");
int Xb = int.Parse(Console.ReadLine()!);
Console.Write("Введите Ya: ");
int Ya = int.Parse(Console.ReadLine()!);
Console.Write("Введите Yb: ");
int Yb = int.Parse(Console.ReadLine()!);

double Distans = Math.Sqrt(Math.Pow(Xa - Xb, 2) + Math.Pow(Ya - Yb, 2));
Console.WriteLine($"Расстояние между точками А и B -> {Distans:f2}");
 