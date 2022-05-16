// Задайте двумерный массив. Напишите программу,которая поменяет местами 
//первую и последнюю строку массива.
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

// int[,] array =
// {
//     {1,2,3},
//     {4,5,6},
//     {7,8,9}
// };

//     for (int j=0;j<array.GetLength(1);j++)
//     {
//         int temp = array[0,j];
//         array[0,j] = array[array.GetLength(0)-1,j];
//         array[array.GetLength(0)-1,j] = temp;
//     }

// PrintArray(array);


// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя


// int[,] matrix =
// {
//     {1,2,3},    // 1, 4, 7
//     {4,5,6},    // 2, 5, 8
//     {7,8,9}     // 3, 6, 9
// };

// if (matrix.GetLength(0)!=matrix.GetLength(1))
// Console.WriteLine("Замена невозможна, матрица не квадратная.");
// else
// {
//     int[,] matrix1= new int[matrix.GetLength(0),matrix.GetLength(1)];
//     for (int i=0;i<matrix1.GetLength(0);i++)
// {
//     for (int j=0;j<matrix1.GetLength(1);j++) // int j=i для смещения по диаганали
//     {
//         matrix1[i,j] = matrix[j,i];
//     }
// }
// PrintArray(matrix1);
// };

// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
//информацию о том, сколько раз встречается элемент входных данных.

// int[] array = 
// {1, 9, 9, 0, 2, 8, 0, 9};

// int count =0;
// int[] unique = new int [1];
// unique[0] = array[0];

// for (int j=0;j<unique.Length;j++)
// {
//     for (int i=0; i<array.Length;i++)
//     {
//     if (array[i] == unique[j])
//     {
//         count = count +1;
//     }
//     }
//     Console.WriteLine($"Количество элементов {unique[j]}: {count}");
// }

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.

int [,] array =
{
    {1,4,5,2},
    {5,9,2,3},
    {8,4,2,4},
    {5,2,6,7},
};

int min = array[0,0];
int row = 0;
int colomn = 0;

for (int i=0;i<array.GetLength(0);i++)
{
    for (int j=0;j<array.GetLength(1);j++)
    {
        if (array[i,j]<min)
        min = array[i,j];
        row = i;
        colomn =j;
    }
}

int [,] newarray = new int[array.GetLength(0)-1,array.GetLength(1)-1];

for (int i=0;i<newarray.GetLength(0);i++)
{
    for (int j=0;j<newarray.GetLength(1);j++)
    {
        
        if (i == row ^ j ==colomn)
        newarray[i,j] = array[i+1,j+1];
        else
        newarray[i,j] = array[i,j];
    }
}

Console.WriteLine("Минимальное число: "+min);
PrintArray(newarray);