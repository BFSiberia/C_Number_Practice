// Задача 46. Задайте двумерный массив размером m * n, заполенный случайными целыми числами

int[,] FillArrayDouble(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
    return array;
}

void PrintArrayDouble(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//PrintArrayDouble(FillArrayDouble(2, 2));

// Задача 48. Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: A =индекс строки + индекс столбца.
// Вывести полученный массив на экран.

// int x = 3, y = 4;

// int[,] mas = new int[x, y];

// for (int i = 0; i < mas.GetLength(0); i++)
// {
//     for (int j = 0; j < mas.GetLength(1); j++)
//     {
//         mas[i, j] = i + j;
//     }
// }

// PrintArrayDouble(mas);

// Задача 49. Задайте двумерный массив. Найдите элементы,
// у которых оба индекса четные и замените эти элементы на их квадраты.

int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
    }
}
PrintArrayDouble(matrix);

for (int i = 0; i < matrix.GetLength(0); i = i + 2)
{
    for (int j = 0; j < matrix.GetLength(1); j = j + 2)
    {
        //if (i%2==0 && j%2==0)
        matrix[i, j] = matrix[i, j] * matrix[i, j];
    }
}
PrintArrayDouble(matrix);

// Задача 51. Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами 0,0 1,1)

int sum = 0;
int size = matrix.GetLength(0);                 // Вместо проверок по всему массиву
if (matrix.GetLength(1) < matrix.GetLength(0))  // находим меньшую сторону
    size = matrix.GetLength(1);
for (int i = 0; i < size; i++)                  // проверям условие только по ней
{
    sum = sum + matrix[i,i];                    // по условию задачи индексы равны
}
Console.WriteLine(sum);