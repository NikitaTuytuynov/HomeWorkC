// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
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

int SumArray(int[] array)
{
    int sum = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0 || (i % 2) == 0) sum = sum + array[i];
    }
    return sum;
}
int[] arr = ArrayCreate(8, -100, 100);
ArrayPrint(arr);
int summa = SumArray(arr);
Console.Write($" -> {summa}");