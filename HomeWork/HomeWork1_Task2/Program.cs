int a, b, max;
a = 5;
b = 7;
max = a;

if(a==b) Console.WriteLine("Числа a и b равны.");
else
{
    if (b>a)
    {
    max = b;
    Console.WriteLine($"Число b ({b}) больше числа a ({a}).");
    }
    else Console.WriteLine($"Число a ({a}) больше числа b ({b}).");
}

a = 2;
b = 10;
max = a;

if(a==b) Console.WriteLine("Числа a и b равны.");

else
{
    if (b>a)
    {
    max = b;
    Console.WriteLine($"Число b ({b}) больше числа a ({a}).");
    }
    else Console.WriteLine($"Число a ({a}) больше числа b ({b}).");
}

a = -9;
b = -3;
max = a;

if(a==b) Console.WriteLine("Числа a и b равны.");

else
{
    if (b>a)
    {
    max = b;
    Console.WriteLine($"Число b ({b}) больше числа a ({a}).");
    }
    else Console.WriteLine($"Число a ({a}) больше числа b ({b}).");
}