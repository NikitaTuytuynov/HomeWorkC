// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 1;

void NaturalNumbers(int num, int num1)
{
    if (num1 == num + 1) return;
    NaturalNumbers(num, num1 + 1);
    Console.Write($"{num1} ");
}

NaturalNumbers(number, number1);