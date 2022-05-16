// Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}

int RowSum(int[,] array, int n)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[n, j];
    }
    return sum;
}

int[,] array = new int[3, 4];

FillArray(array);
PrintArray(array);

int minSumLineIndex = 0;
for (int i = 1; i < array.GetLength(0); i++)
{
    if
    (RowSum(array, i)<RowSum(array, minSumLineIndex))
    minSumLineIndex = i;
}
Console.WriteLine($"Строка с минимальной суммой элементов: {minSumLineIndex + 1}.");