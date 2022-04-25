void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

int[] mas = new int[12];
FillArray(mas);
Console.Write("Массив:");
PrintArray(mas);

int sumPlus = 0;
int sumMinus = 0;

for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] > 0) sumPlus += mas[i];
    else sumMinus += mas[i];
}
Console.WriteLine($"Сумма положительных элементов массива: {sumPlus}.");
Console.WriteLine($"Сумма отрицательных элементов массива: {sumMinus}.");