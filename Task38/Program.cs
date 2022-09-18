// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] ArrayCreate(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 100, 1);
    }
    return array;
}



void ArrayPrint(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}


double MaxValue(double[] array)
{
    double max1 = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max1)
        {
            max1 = array[i];
        }
    }
    return max1;
}

double MinValue(double[] array)
{
    double min1 = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min1)
        {
            min1 = array[i];
        }
    }
    return min1;
}

double[] arr = ArrayCreate(5, 0, 1);
ArrayPrint(arr); 
double max2 = MaxValue(arr);
double min2 = MinValue(arr);
double result = max2 - min2;
Console.Write($" -> {result}");