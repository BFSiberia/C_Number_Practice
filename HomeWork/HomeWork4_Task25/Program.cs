// Принимает два числа (A и B) и возводить число A в степень B

void PowResult(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"Число {a} в степени {b} равно {result}.");
}

PowResult(3,5);
PowResult(2,4);