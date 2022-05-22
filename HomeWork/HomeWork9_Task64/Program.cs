// Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.

void NaturalNumber(int m, int n)
{
    if (m == n)
    {
        Console.Write(m);
        return;
    }


    else if (m < n)
    {
        Console.Write(m + " ");
        NaturalNumber(m + 1, n);
    }
    else
    {
        Console.Write(m + " ");
        NaturalNumber(m - 1, n);
    }
}

NaturalNumber(4, 8);
Console.WriteLine();
NaturalNumber(8, 4);
