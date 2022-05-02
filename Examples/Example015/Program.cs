void FillArray (int[] array)
{
for(int i=0; i<array.Length;i++)
{
    array[i]= new Random().Next(0,100);
}
}

void PrintArray (int[] array)
{
for (int i =0; i<array.Length;i++)
{
    Console.Write(array[i] +" ");
}
Console.WriteLine();
}

void PrintArray2 (int[,] array)
{
for (int i =0; i<array.GetLength(0);i++)
{
    for (int j =0; j<array.GetLength(1);j++)
    Console.Write(array[i,j] +" ");
    Console.WriteLine();
}
}

//Напишите программу, которая переернет одномерный массив.
// int [] mas = new int [9];

// for (int i = 0; i<mas.Length; i++)
// {
//     mas[i] = new Random().Next(0,100);
//     Console.Write(mas[i] + " ");
// }
// Console.WriteLine();

// int temp = 0;
// for (int i = 0; i<mas.Length/2; i++)
// {
//     temp = mas[i];
//     mas[i] = mas[mas.Length-1-i];
//     mas[mas.Length-1-i] = temp;
// }

// PrintArray(mas);

// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// сторона треугольника меньше сумме двух других

int[,] SideSize (int a, int b, int c)
{
int[,] sides = 
{
{a,b,c},
{b,c,a},
{c,a,b}
};
return sides;
}

//PrintArray2(SideSize(7,2,3));

bool TriangleSides (int [,] array)
{
    bool result=true;
    for(int i=0;i<array.GetLength(0);i++)
    {
        if (array[0,i]>array[1,i]+array[2,i])
        result= false;
        break;
    }    
    return result;
}
if (TriangleSides(SideSize(7,2,3))) Console.WriteLine("Треугольник существует");
else Console.WriteLine("Треугольник не существует");

// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101 45/2 = 22 и 1 - пишем 1, 22/2 =11 - пишем 0, 11/2 = 5 и 1  - пишем 1,
//5/2=2 и 1 - пишем 1, 2/2 = 1 пишем 0, 1/2 = 0,5 - пишем 1.
// 3 -> 11
// 2 -> 10


int n = 45;
// string result = String.Empty;
// while (n>0)
// {
// result = n%2 + result;
// n=n/2;
// }
// Console.WriteLine(result);

int[] DecToDouble (int number)
{
int[] array = new int[1];
for (int i =0; i<array.Length; i++)
{
    array[i] = number%2;
    number=number/2;
    if (number>0)
    Array.Resize(ref array, array.Length + 1);
}
Array.Reverse(array);
return array;
}

PrintArray(DecToDouble(n));

// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// int n = 7;
// int[] result = new int[n];

// result[0] = 0;
// result[1] =1;

// for(int i=2;i<n;i++)
// {
//     result[i] = result[i-2]+result[i-1];
// }

// for (int i =0; i<result.Length;i++)
// {
//     Console.Write(result[i] +" ");
// }

// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования

// int[] mass = new int[5];

// FillArray(mass);
// Console.Write("Массив 1: ");
// PrintArray(mass);

// int[] mass2 = new int[mass.Length];

// for(int i =0; i<mass2.Length;i++)
// {
//     mass2[i] = mass[i];
// }

// Console.Write("Массив 2: ");
// PrintArray(mass2);