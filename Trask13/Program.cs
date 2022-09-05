// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры не
// 32679 -> 6


Console.Clear();
Console.Write("Ведите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = num;
if (num > 99)
{
    while (count > 999)
    {
        count = count / 10;
    }
    int thirdDigit = count % 10;
    Console.Write($"{num} -> {thirdDigit}");
}
else Console.Write("Третьей цифры нет ");