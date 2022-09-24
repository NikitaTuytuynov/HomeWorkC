// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Clear();
Console.Write("Введите № строки: ");
int i1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите № столбца: ");
int j1 = Convert.ToInt32(Console.ReadLine());
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


void FindMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int colums = matrix.GetLength(1);
    if (i1 <= rows && j1 <= colums)
    {
        Console.Write($" -> {matrix[i1 - 1, j1 - 1]}");
    }
    else Console.Write("Такого элемента в массиве нет");
}

int[,] array2D = ArrayCreate(3, 4, 1, 9);
MatrixPrint(array2D);
FindMatrix(array2D);