// Заполните спирально массив 4 на 4.
int x = 4;
int y=4;
int[,] spiral = new int[x, y];

int n = 1;
int left = 0, right = spiral.GetLength(0) - 1, top = 0, bottom = spiral.GetLength(1) - 1;

int direction = 1;

while (top <= bottom && left <= right)
{
    if (direction == 1) //движение с слева на право
    {
        for (int i = left; i <= right; i++)
        {
            spiral[top, i] = n++;
        }
        top++; // спуск ни 1 строку вниз
        direction = 2;
    }
    else if (direction == 2) // движение сверху вниз
    {
        for (int i = top; i <= bottom; i++)
        {
            spiral[i, right] = n++;
        }
        right--; // возврат на 1 столбец назад
        direction = 3;
    }
    else if (direction == 3) // движение справа на лево
    {
        for (int i = right; i >= left; i--)
        {
            spiral[bottom, i] = n++;
        }
        bottom--; // возврат на 1 строку назад
        direction = 4;
    }
    else if (direction == 4) // движение снизу вверх
    {
        for (int i = bottom; i >= top; i--)
        {
            spiral[i,left] = n++;
        }
        left++; // сдвиг на 1 столбец вправо
        direction = 1;
    }
}

for (int i = 0; i < spiral.GetLength(0); i++)
{
    for (int j = 0; j < spiral.GetLength(1); j++)
    {
        Console.Write(" " + spiral[i, j]);
    }
    Console.WriteLine();
}