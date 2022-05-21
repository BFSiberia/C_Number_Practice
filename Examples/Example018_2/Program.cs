// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void NaturalNumber(int m, int n)
{
    if (n+1==m)
    return;
   
    Console.Write(m+" ");
    m = m+1;
    NaturalNumber(m,n);
}

NaturalNumber(4,8);