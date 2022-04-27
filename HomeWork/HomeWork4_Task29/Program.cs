// Задает массив из 8 элементов и выводит на экран
//1,2,5,7,19
//6,1,33

int[] CreateArrayN(int n)
{
    int[] array = new int[n];
    for(int i = 0; i<array.Length;i++)
    {
        array[i] = new Random().Next(1,50); // Случайное число
        //Console.Write($"Введите элемент массива {i+1}: "); // Число из консоли
        //array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"Создан массив: ");
    for(int i = 0; i<array.Length;i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PrintArray(CreateArrayN(8));
