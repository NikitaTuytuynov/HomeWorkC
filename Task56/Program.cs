// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int[,] ArrayCreate(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void MatrixPrint(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine("]");
    }
}

void MatrixCount(int[,] matrix)
{
    int count = default;
    int row = default;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumrow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumrow += matrix[i, j];
        }
        if (i == 0)
            count = sumrow;
        if (sumrow < count)
        {
            count = sumrow;
            row = i;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {row + 1}, с суммой {count}.");
}


int[,] array2D = ArrayCreate(4, 4, 1, 9);
MatrixPrint(array2D);
MatrixCount(array2D);
