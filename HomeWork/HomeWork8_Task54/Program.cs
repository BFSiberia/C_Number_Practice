// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
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

void RowSort(int[,] array, int n) // Сортирует элементы строки n в array по возрастанию
{
    for (int i = 0; i < array.GetLength(1); i++) //Проход по строке n
    {
        int max = i;                            // Задаем индекс минимального элемента строки
        for (int j = i; j < array.GetLength(1); j++)  // Ищем минимальный элемент в неотсорт. части
        {

            if (array[n, j] > array[n, max])
            {
                max = j;                        // При нахождении нового мин. элемента
            }                                   // заменяем индекс
        }

        if (array[n, max] == array[n, i])         // если мин элемент равен текущему - оставляем
            continue;

        int temp = array[n, i];                  // замена мин элмента на первый
        array[n, i] = array[n, max];              // в не отсортированной части
        array[n, max] = temp;
    }
}

int[,] array = new int[3, 4];

FillArray(array);
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++) // Проход по всем строкам array
{
    RowSort(array, i);
}

Console.WriteLine();
PrintArray(array);