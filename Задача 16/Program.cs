// Задача №16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// ● 5, 25 -> да
// ● -4, 16 -> да
// ● 25, 5 -> да
// ● 8,9 -> нет
Console.Clear();

Console.WriteLine ("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

//if (B * B == A || A * A == B) 
//if (Math.Pow (B, 2) == A || Math.Pow (A, 2) == B) 
if (A % B == 0 || B % A == 0)
{
    Console.WriteLine("Да");    
}
else
{
    Console.WriteLine("Нет");
}