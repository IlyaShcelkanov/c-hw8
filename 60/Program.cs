// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Get3DArray(int x, int y, int z, int min, int max)
{
    int[,,] res = new int[y, x, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                res[i, j, k] = new Random().Next(min, max);
            }
        }
    }
    return res;
}

void PrintArray(int[,,] inArray)
{
    for (int x = 0; x< inArray.GetLength(0); x++)
    {
        for (int y = 0; y < inArray.GetLength(1); y++)
        {
            for (int z = 0; z < inArray.GetLength(2); z++)
            {
                Console.Write($"{inArray[x, y, z]}{(x, y, z)} ");
            }
            Console.WriteLine();
        }
        
    }
}

Console.Write("x = ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("y = ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("z = ");
int z = int.Parse(Console.ReadLine()!);
int[,,] array = Get3DArray(x, y, z, 0, 10);
PrintArray(array);

