// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();
Console.Write("Введите число   : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную степень : ");
int b = Convert.ToInt32(Console.ReadLine());
int num = 1;

object Pow(int a1, int b1, int num1)
{
    if (b1 > 0)
    {
        for (int i = 0; i < b1; i++)
        {
            num1 = num1 * a1;
        }
        return $"{a1} в степени {b1} = {num1}";
    }
    return "Ошибка, введите натуральную степень";
};

object power = Pow(a, b, num);
Console.Write(power);



