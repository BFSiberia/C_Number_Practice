// Сформируйте трехмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет выводить массив построчно,
// добавляя индексы каждого элемента.

int[,,] triple = new int[3, 2, 2];
int[] unique = new int[triple.Length]; // массив уникальных чисел
bool exist = false; // переменная проверки уникальности
int count = 0; // индекс в массиве уникальных чисел

for (int i = 0; i < triple.GetLength(0); i++)
{
    for (int j = 0; j < triple.GetLength(1); j++)
    {
        for (int k = 0; k < triple.GetLength(2); k++)
        {
            triple[i, j, k] = new Random().Next(1, 13);
            exist = false;
            for (int c = 0; c < count; c++) //поиск и добавление уник. чисел
            {
                if (triple[i, j, k] == unique[c]) // если число найдено в массиве уник. чисел
                {
                    exist = true;
                    k--;    // повторная генерация случайного числа в ячейке
                    break;      // цикл поиска прерывается
                }
            }
            if (exist == false) // если число не найдено
            {
                Console.Write($"Число: {triple[i, j, k]}, индекс: ({i},{j},{k}). ");
                unique[count] = triple[i, j, k]; // текущий индекс получает значение уник. числа
                count++; // следующий индекс
            }
        }
    }
    Console.WriteLine();
}