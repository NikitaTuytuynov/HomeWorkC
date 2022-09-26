// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] MultiMatrix(int[,] array2D, int[,] array2D1)
{
    if (array2D.GetLength(1) != array2D1.GetLength(0))
    {
        Console.WriteLine("Ошибка, можно перемножать только такие матрицы у которых число столбцов в первой матрице равно числу строк во второй матрице.");
        Environment.Exit(0);
    }
    int[,] multi = new int[array2D.GetLength(0), array2D1.GetLength(1)];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D1.GetLength(1); j++)
        {
            for (int d = 0; d < array2D1.GetLength(0); d++)
            {
                multi[i, j] = multi[i, j] + array2D[i, d] * array2D1[d, j];
            }
        }
    }
    return multi;
}

Console.WriteLine("Матрица 1");
int[,] array2D = ArrayCreate(2, 2, 1, 9);
MatrixPrint(array2D);
Console.WriteLine("---------");
Console.WriteLine("Матрица 2");
int[,] array2D1 = ArrayCreate(2, 2, 1, 9);
MatrixPrint(array2D1);
Console.WriteLine("Результат умножения матриц :");
int[,] arraymulti = MultiMatrix(array2D, array2D1);
MatrixPrint(arraymulti);
