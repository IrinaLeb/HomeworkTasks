// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();

Console.WriteLine("Введите два числа ");
int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);

if (A > B)
{
    Console.WriteLine($"{A} - max");
    Console.WriteLine($"{B} - min");
}

if (A == B)
{
    Console.WriteLine("Введите разные числа.");
}

else 

{   
    Console.WriteLine($"{A} - min");
    Console.WriteLine($"{B} - max"); 
}
