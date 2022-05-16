// Задайте двумерный массив. Напишите программу,которая поменяет местами 
//первую и последнюю строку массива.
int[,] FillArrayDouble(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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
}

void PrintArraySingle(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
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

// PrintArrayDouble(array);


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
//     for (int j=0;j<matrix1.GetLength(1);j++) // int j=i для смещения по диагонали
//     {
//         matrix1[i,j] = matrix[j,i];
//     }
// }
// PrintArrayDouble(matrix1);
// };

// Задача 57. Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит  информацию о том, сколько раз 
// встречается элемент входных данных.

int[] arraySingle =
{1, 9, 9, 0, 2, 8, 0, 9};

int[,] arrayDouble = FillArrayDouble(3,3);
// {
//     {1, 2, 3},
//     {4, 6, 1},
//     {2, 1, 6}
// };

int[,] unique = new int[arrayDouble.Length, 2];
int count = 0;
bool exist = false; // переменная для проверки вхождения в новый массив

for (int i = 0; i < arrayDouble.GetLength(0); i++)  //проход по строкам исходного массива
{
    for (int j = 0; j < arrayDouble.GetLength(1); j++)  // проход по столбцам
    {
        exist = false;             // сброс проверки вхождения
        for (int c = 0; c < count; c++) // цикл для проверки вхождения уникального элемента
        {
            if (arrayDouble[i, j] == unique[c, 0])        // проверка вхождения
            {
                exist = true;
                unique[c, 1]++;                     // счетчик уникального числа
                break;                              //остановка цикла
            }
        }
        if (exist == false)                     // если нет вхождения
        {
            unique[count, 0] = arrayDouble[i, j];  // элемент входит в уникальный массив 
            unique[count, 1] = 1;       // начало счета уникального числа
            count++;                  // сдвиг на пустой элемент уник. массива
        }
    }
}

PrintArrayDouble(unique);

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Цифра {unique[i, 0]} встречается {unique[i, 1]} раз.");
}

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.

// int [,] array =
// {
//     {1,4,5,2},
//     {5,9,2,3},
//     {8,4,2,4},
//     {5,2,6,7},
// };

// int min = array[0,0];
// int row = 0;
// int colomn = 0;

// for (int i=0;i<array.GetLength(0);i++)
// {
//     for (int j=0;j<array.GetLength(1);j++)
//     {
//         if (array[i,j]<min)
//         min = array[i,j];
//         row = i;
//         colomn =j;
//     }
// }

// int [,] newarray = new int[array.GetLength(0)-1,array.GetLength(1)-1];

// for (int i=0;i<newarray.GetLength(0);i++)
// {
//     for (int j=0;j<newarray.GetLength(1);j++)
//     {

//         if (i == row ^ j ==colomn)
//         newarray[i,j] = array[i+1,j+1];
//         else
//         newarray[i,j] = array[i,j];
//     }
// }

// Console.WriteLine("Минимальное число: "+min);
// PrintArray(newarray);