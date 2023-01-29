// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Clear();

Console.WriteLine("Введите три числа ");
int A = int.Parse (Console.ReadLine()!);
int B = int.Parse (Console.ReadLine()!);
int C = int.Parse (Console.ReadLine()!);

if (A > B && A > C)
{
    Console.Write(A);
}

else if (B > C)
{
    Console.Write(B);
}

else 
{
    Console.Write(C);
}