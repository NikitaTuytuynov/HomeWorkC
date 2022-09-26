// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

int[,] MatrixStreamline(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int d = 0; d < matrix.GetLength(1) - 1; d++)
            {
                if (matrix[i, d] < matrix[i, d + 1])
                {
                    temp = matrix[i, d];
                    matrix[i, d] = matrix[i, d + 1];
                    matrix[i, d + 1] = temp;
                }
            }

        }
    }
    return matrix;
}

int[,] array2D = ArrayCreate(3, 4, 1, 9);
MatrixPrint(array2D);
Console.WriteLine("------------------------------------------------------");
int[,] array2D1 = MatrixStreamline(array2D);
MatrixPrint(array2D1);
