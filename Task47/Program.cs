// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();
double[,] ArrayCreate(int rows, int colums, int min, int max)
{
    double[,] matrix = new double[rows, colums];
    Random rnd = new Random();
    Random rnd1 = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd1.Next(min, max +1) + Math.Round(rnd.NextDouble(), 1) ;
        }
    }
    return matrix;
}

void MatrixPrint(double[,] matrix)
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

double[,] array2D = ArrayCreate(3, 4, -10, 9);
MatrixPrint(array2D);