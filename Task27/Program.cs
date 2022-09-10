// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Console.Clear();


Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = default;

int Summa(int num1, int sum1)
{
    {
        while (num1 > 0)
        {
            sum1 = sum1 + num1 % 10;
            num1 = num1 / 10;
        }
    }
    return sum1;
}

sum = Summa(num, sum);
Console.WriteLine(sum);

