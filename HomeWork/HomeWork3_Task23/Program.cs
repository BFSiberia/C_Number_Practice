// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

double number, result;
Console.Write("Введите число: ");
number = double.Parse(Console.ReadLine());
int i = 1;

Console.Write($"Список кубов от 1 до {number}: ");

while (i<number)
{
    result = Math.Pow(i,3);
    Console.Write($"{result}, ");
    i++;
}
result = Math.Pow(i,3);
Console.Write($"{result}.");
