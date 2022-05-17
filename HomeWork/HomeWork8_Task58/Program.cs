// Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
void FillArrayDouble(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
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

void MatrixMultiply(int[,] array1, int[,] array2)
{
    if (array1.GetLength(0) != array2.GetLength(1))
        Console.WriteLine("Матрицы не совместимы, перемножение не возможно.");

    else
    {
        int[,] multiplyResult = new int[array1.GetLength(0), array2.GetLength(1)];
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int x = 0; x < array2.GetLength(0); x++)
                {
                    multiplyResult[i, j] += array1[i, x] * array2[x, j];
                }
                Console.Write(" "+multiplyResult[i, j]);
            }
            Console.WriteLine();
        }
    }
}

int[,] matrix1 = new int[3, 3];
int[,] matrix2 = new int[3, 3];

FillArrayDouble(matrix1);
PrintArrayDouble(matrix1);
FillArrayDouble(matrix2);
PrintArrayDouble(matrix2);
MatrixMultiply(matrix1, matrix2);