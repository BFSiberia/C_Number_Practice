// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт
// первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26

int a=3;
int b=4;
int c=5;
double SumDouble(int n)
{
    if (n==1) return a;
    else if (n==2) return b;
    else return SumDouble(n-1) + SumDouble(n-2);
}

for(int i=1;i<=c;i++)
{
    Console.Write(SumDouble(i)+" ");
}