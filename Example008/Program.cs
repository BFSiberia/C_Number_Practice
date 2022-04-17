int number;
int i = 1;

number = 5;

if (number == 0)
{
    Console.WriteLine("Ноль");
}
else while (i <= Math.Abs(number))
{
    Console.WriteLine(Math.Pow(i, 2));
    i++;
}
