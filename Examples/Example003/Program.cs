
int number, i;

number = 0;
i = -number;

while (i <= number)
{
    if (i == number)
        Console.Write($"{i}. ");
    else
        Console.Write($"{i}, ");
i++;
}

int num = 782;
num %= 10; // number = number % 10;
Console.WriteLine(num);