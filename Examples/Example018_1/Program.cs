// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void SomeRec(int a, int b)
{
    if (a+1 == b)
        return;
    Console.Write(b+" ");
    SomeRec(a,b+1);
}

SomeRec(5,1);