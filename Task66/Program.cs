// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите число M: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int summa = default;

int SumNumbers(int num, int num1, int sum)
{
    while (num < num1 + 1)
    {
        SumNumbers(num + 1, num1, sum);
        sum = sum + num;
        num++;
    }
    return (sum);
}
int rez = SumNumbers(number, number1, summa);
Console.Write(rez);