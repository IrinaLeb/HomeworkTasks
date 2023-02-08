// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();

int Erect(int D, int C)
{ 

int S = 1;
for (int i = 1; i <= C; i++)
    {
        S *= D; // Degree *= A;
    }
    return S;
}

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} возведённое в степень {B} равно {Erect(A, B)}");