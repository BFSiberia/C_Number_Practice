double number, result;
Console.Write("Введите число:: ");
number = double.Parse(Console.ReadLine());
int i = 1;

Console.Write($"Список кубов числа {number}: ");

if (i == number)
{
    result = Math.Pow(i,3);
    Console.Write($"{result}.");
}
else
{
    while (i<number)
    {
        result = Math.Pow(i,3);
        Console.Write($"{result}, ");
        i++;
    }
    result = Math.Pow(i,3);
    Console.Write($"{result}.");
}