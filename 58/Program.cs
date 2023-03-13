// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] GetArray(int m, int n, int min, int max)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(min, max);
        }
    }
    return res;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < result.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            result[i,j] = sum;
        }
    }
    return result;
}


// Console.Write("row = ");
// int row = int.Parse(Console.ReadLine()!);
// Console.Write("col = ");
// int col = int.Parse(Console.ReadLine()!);
Console.WriteLine("Matrix1");
int[,] matrix1 = GetArray(2, 2, 0, 10);
PrintArray(matrix1);
Console.WriteLine("Matrix2");
int[,] matrix2 = GetArray(2, 2, 0, 10);
PrintArray(matrix2);
int[,] resultMatrix = MultiplicationMatrix(matrix1, matrix2);
Console.WriteLine("result matrix");
PrintArray(resultMatrix);
