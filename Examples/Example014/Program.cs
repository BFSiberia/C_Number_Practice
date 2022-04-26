// // Задача 35.
// // задать массив из 123 чисел
// // найти количество элементов в отрекзе [10,99]

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
    Console.WriteLine();
}

// int[] array = new int[123];
// CreateArray(array);
// PrintArray(array);

// int count = 0;
// for(int i=0;i<array.Length;i++)
// {
//     if(array[i]>=10& array[i]<100) count = count +1;
// }
// Console.WriteLine($"В массиве {count} элементов в диапазоне от 10 до 99.");

// Задача 37.
// Найти произведение пар чисел первый и последний, второй и предпоследний.

int[] array = new int[6];

void Pair(int[] array)
{
int [] result = new int[array.Length/2];
if (array.Length%2!=0) 
{
Array.Resize(ref result, result.Length + 1);
result[result.Length-1]= array[array.Length/2];
}
for(int i=0; i<array.Length/2;i++)
{
    result[i] = array[i]*array[array.Length-1-i];
}
PrintArray(result);
}

CreateArray(array);
PrintArray(array);
Pair(array);
