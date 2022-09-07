// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



// ДОБАВИЛ ПРОВЕРКУ НА ПОЛОЖИТЕЛЬНОСТЬ ЧИСЛА
Console.Clear();
Console.WriteLine("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());
int count = 1;
void Сube(int digit1, int count1)
{
    if (digit1 > 0)
    {
        while (count1 <= digit1)
        {
            Console.WriteLine($"{count1} -> {count1 * count1 * count1}");
            count1++;
        }
    }
    else Console.WriteLine("Введите положительное число ");
}
Сube(digit, count);