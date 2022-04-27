// Задает массив из 8 элементов и выводит на экран
//1,2,5,7,19
//6,1,33

int[] CreateArrayN(int n)
{
    int[] array = new int[n];
    for(int i = 0; i<array.Length;i++)
    {
        Console.Write($"Введите элемент массива {i+1}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"Сгенерированный массив: ");
    for(int i = 0; i<array.Length;i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PrintArray(CreateArrayN(8));