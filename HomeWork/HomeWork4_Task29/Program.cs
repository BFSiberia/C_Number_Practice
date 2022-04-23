// Задает массив из 8 элементов вывод на экран
//1,2,5,7,19
//6,1,33

void CreateArray(int[] array)
{
    for(int i = 0; i<array.Length;i++)
    {
        array[i] = new Random().Next(1,100);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i<array.Length;i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] array = new int[8];

CreateArray(array);
Console.Write("Сгенерированный массив: ");
PrintArray(array);