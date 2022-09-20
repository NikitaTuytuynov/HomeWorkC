// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите число элементов массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] ArrayCreate(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите число № {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

int ArrayCount(int[] array)
{
    int cou = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) cou++;
    }
    return cou;

}

int[] arr = ArrayCreate(size);
ArrayPrint(arr);
int count = ArrayCount(arr);
Console.Write($"Положительных чисел :{count} ");