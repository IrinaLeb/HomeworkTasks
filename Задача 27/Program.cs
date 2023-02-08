// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();

int getSum(int number)
{ 
    int sum = 0;
    while (number != 0)
        {
            sum = sum + number % 10;
            number = number / 10;
        }
    return sum;
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма числа {num} равна {getSum(num)}");