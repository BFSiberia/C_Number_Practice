// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void CreateArray(int[] array)
{
    for(int i = 0; i<array.Length;i++)
    {
        array[i] = new Random().Next(100,1000);
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

void CountEven(int[] array)
{
int count = 0;
for(int i =0;i<array.Length;i++)
{   
    if (array[i]%2==0) count++;
}
Console.WriteLine("Количество четных числе в массиве: " + count);
}

int[] array = new int [7];

CreateArray(array);
PrintArray(array);
CountEven(array);
