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

void PrintGroups(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"Группа {i + 1}: ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0)
                break;
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
bool Check(int a, int b)
{
    return (a % b == 0 || b % a == 0);
}
int LinesCount(int x)
{
    int lines = 0;
    int count = 1;
    while (count < x)
    {
        count *= 2;
        lines++;
    }
    return lines;
}

int x = 50;

int[,] array = new int[LinesCount(x), (int)Math.Ceiling((decimal)x/3)];

int l = 0;

for (int i = 1; i <= x; i++)
{
    for (int k = 0; k < array.GetLength(1); k++)
    {
        if (array[l, k] == 0)
        {
            array[l, k] = i;
            l = 0;
            break;
        }
        else if (Check(i, array[l, k]))
        {
            l++;
            k = -1;
            continue;
        }
    }
}
PrintGroups(array);


