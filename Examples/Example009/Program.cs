// //Программа, принимает число N и выдает сумму чисал от 1 до N

// int Summary(int N)
// {
// int sum = 0;
// for(int i=1; i<=N;i++)
// {
//     sum += i;
// }
// return sum;

// }
// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine());

// Summary(N);

// Напишите программу на выходе произведение от 1 до N

int Mult(int N)
{
int sum = 1;
    for(int i=1; i<=N;i++)
    {
        sum = sum*i;
    }
    return sum;
 }

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine(Mult(N));
