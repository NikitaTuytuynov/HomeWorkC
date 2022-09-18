// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Ведите первое число диапозона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите второе число диапозона: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите количество проверяемых чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
if (min < max)
{
    int[] ArrayCreate(int size, int min, int max)
    {
        int[] array = new int[size];
        Random rnd = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = rnd.Next(min, max + 1);
        }
        return array;
    }

    void ArrayPrint(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length - 1) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}");
        }
        Console.Write("]");
    }
    int[] arr = ArrayCreate(size, min, max);
    ArrayPrint(arr);

    int EvenDigit(int[] array)
    {
        int count = default;
        for (int i = 0; i < array.Length; i++)
            if ((array[i] % 2) == 0) count++;
        return count;
    }

    int cou = EvenDigit(arr);
    Console.Write($" -> {cou} Чётных чисел");
}
else Console.Write("Введен неверный диапозон");
