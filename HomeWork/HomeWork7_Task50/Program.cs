// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве и возврашает значение этого элемента.
//или же указание, что такого элемента нет
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 элемента 17 нет

void CreateArray (int [,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        array[i,j] = new Random().Next(1,10);
    }
}

void PrintArray (int [,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        Console.Write($" {array[i,j]}");
        Console.WriteLine();
    }
}

int [,] matrix = new int [3,4];
CreateArray(matrix);
PrintArray(matrix);

Console.WriteLine("Введите позицию искомого элемента: ");
int element = int.Parse(Console.ReadLine());

if (element>matrix.GetLength(0)*matrix.GetLength(1))
{
    Console.WriteLine("Такого элемента не существует.");
}
else
{
    int count = 1;
    for (int i=0;i<matrix.GetLength(0);i++)
    {
        for (int j=0;j<matrix.GetLength(1);j++)
        {
            if (count == element)
            {
            Console.WriteLine($"Искомый элемент находится на позиции {i}, {j}");
            return;
            }   
            else
            count++;
        }
    }
}