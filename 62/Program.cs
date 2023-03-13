// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] GetArray(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    int num = 1;
    int rowStart = 0;
    int rowEnd = m - 1;
    int colStart = 0;
    int colEnd = n - 1;

    while (num <= m * n)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            arr[rowStart, i] = num;
            num++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            arr[i, colEnd] = num;
            num++;
        }
        colEnd--;

        for (int i = colEnd; i >= colStart; i--)
        {
            arr[rowEnd, i] = num;
            num++;
        }
        rowEnd--;

        for (int i = rowEnd; i >= rowStart; i--)
        {
            arr[i, colStart] = num;
            num++;
        }
        colStart++;
    }
    return arr;
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


Console.Write("row = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("col = ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, col, 0, 10);
PrintArray(array);