// Задайте двумерный массив из целых чисел.Найдите среднее арифметическое 
// элементов в каждом столбце.

void CreateArray(int[,] array)
{
for (int i=0;i<array.GetLength(0);i++)
{
    for (int j=0;j<array.GetLength(1);j++)
    {
        array[i,j] = new Random().Next(1,10);
    }
}
}
void PrintArray(int[,] array)
{
for (int i=0;i<array.GetLength(0);i++)
{
    for (int j=0;j<array.GetLength(1);j++)
    {
        Console.Write($" {array[i,j]}");
    }
    Console.WriteLine();
}
}

int [,] array = new int [4,4];

CreateArray(array);
PrintArray(array);

double sum =0;
for (int i=0;i<array.GetLength(1);i++)
{
    for (int j=0;j<array.GetLength(0);j++)
    {
        sum= sum+array[j,i];
    }
    Console.WriteLine($"Среднее арифметическое по столбцу {i+1}: {sum/array.GetLength(1)}");
    sum=0;
}
