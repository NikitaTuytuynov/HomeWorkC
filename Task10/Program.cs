// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Ведите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int digit = num / 10;
int secondDigit = digit % 10;
if (num > 99 && num < 1000) Console.Write($"{num} -> {secondDigit}");
else Console.Write("Ошибка, введите трёхзначное число");
