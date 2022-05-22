// Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные
// представления нескольких чисел (без разделителя). В массиве data хранится
// информация о количестве бит, которые занимают числа из массива info.
// Напишите программу, которая составит массив десятичных представлений чисел
// массива data с учётом информации из массива info.
int[] array1 = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] array2 = { 2, 3, 3, 1 };


void Transfer(int[] numbers, int[] qty)
{
    int[] result = new int[qty.Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = 0; j < qty[j]; j++)
        {

            result[i] = numbers[j];
            Console.WriteLine(result[i] + " ");

        }
    }
}

Transfer(array1, array2);

