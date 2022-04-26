// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива [3 7 22 2 78] -> 76

void CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 20);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int MaxMinDiff(int[] array)
{
    int min = array[0], max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
    }
    return max - min;
}

int[] array = new int[5];

CreateArray(array);
PrintArray(array);
Console.WriteLine(MaxMinDiff(array));

