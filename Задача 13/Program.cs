// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);


if (num > 99)
{
    {
        while (num > 999)
        num = num / 10;
    }
    
    int res = num % 10;
    Console.WriteLine($"{res}");    
}

else 
Console.WriteLine("Третьей цифры нет.");