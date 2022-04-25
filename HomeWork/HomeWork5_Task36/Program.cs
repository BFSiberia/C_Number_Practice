// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void CreateArray(int[] array)
{
    for(int i = 0; i<array.Length;i++)
    {
        array[i] = new Random().Next(-99,100);
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

void SumOddPos(int[] array)
{
int sum = 0;
for(int i =1;i<array.Length;i++)
{   
    if (i%2!=0) sum=sum+array[i];
}
Console.WriteLine("Сумма элементов на нечетных позициях в массиве: " + sum);
}

int[] array = new int [4];

CreateArray(array);
PrintArray(array);
SumOddPos(array);