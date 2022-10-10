// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
int a1 = num % 100;
int a2 = a1 / 10;
Console.WriteLine($" Вторая цифра числа {a2} ");
