// 32. замена элементов массива: положительные на отрицательные и наоборот
//     -4, -8, 8, 2
void FillArray(int[] array)
{
    for(int i =0;i<array.Length;i++)
    {
        array[i]= new Random().Next(-19,20);
    }
}
void PrintArray(int[] array)
{
    for(int i =0;i<array.Length;i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// int[] array = new int[12];

// FillArray(array);
// PrintArray(array);

// for(int i = 0; i<array.Length;i++)
// {
//     array[i] = -array[i]; 
// }

// PrintArray(array);


// 34. Определить присутсвия заданного числа в массиве
//     4; 6,7,19,345,3 - нет
//     -3; 6,7,19,345,3 - да

bool FindNumb(int[] array, int n)
{       
    bool result =false;
    for(int i=0;i<array.Length;i++)
        {   
        if(array[i]==n) result=true;
        }
    return result;
}
int[] array = new int[12];

FillArray(array);
PrintArray(array);
if (FindNumb(array, 19)) Console.WriteLine($"Число присутствует в массиве");
else Console.WriteLine($"Число отсутствует в массиве");