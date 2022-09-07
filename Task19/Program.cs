// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



// ПЕРВУЮ ЗАДАЧУ СДЕЛАЛ ДЛЯ ЛЮБЫХ ЧИСЕЛ
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
int SwitchDigit(int result1, int number1)
{
    while (number1 > 0)
    {
        result1 = result1 * 10;
        result1 = result1 + number1 % 10;
        number1 = number1 / 10;
    }

    return result1;
}
int result2 = SwitchDigit(result, number);
if (result2 == number) Console.Write($"{number} -> {result2} | Число является палиндромным");
else Console.Write($"{number} -> {result2} | Число не является палиндромным");