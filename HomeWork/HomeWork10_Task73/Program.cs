// Есть число N. Сколько групп M, можно получить при разбиении всех
// чисел на группы, так чтобы в одной группе все числа были взаимно просты (все
// числа в группе друг на друга не делятся)? Найдите M при заданном N и получите
// одно из разбиений на группы N ≤ 10²⁰.

// Например, для N = 50, M получается 6
// - Группа 1: 1
// - Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47
// - Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
// - Группа 4: 8 12 18 20 27 28 30 42 44 45 50
// - Группа 5: 7 16 24 36 40
// - Группа 6: 5 32 48

// Другой пример разбиения на группы с тем же N:
// - Группа 1: 1
// - Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
// - Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
// - Группа 4: 8 12 18 20 27 28 30 42 44 45 50
// - Группа 5: 16 24 36 40
// - Группа 6: 32 48

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int NOD(int x, int y)
{
    return y == 0 ? x : NOD(y, x % y);
}
void PrintArraySingle(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int x = 50;
int[,] array = new int[10, 45];
array [0,0] =1;


for (int i = 2; i <= x; i++)
{
    int count = 1;
    for (int l = 1; l < array.GetLength(0); l++)
    {
        if (array[l, 0] == 0)
        {
            array[l, 0] = i;
            i++;
        }
        for (int c = 0; c <= count; c++)
        {
            if (NOD(i, array[l, c]) != 1)
            {
                break;
            }
        }
        
    }
}



PrintArray(array);


