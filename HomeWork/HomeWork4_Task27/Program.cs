// Сумма цифр в числе: 452 - 11, 82-10, 9012 - 12
void numberSum(int n)
{
    Console.Write($"Сумма цифр числа {n} равняется ");
    int sum = 0;
    for(int i = 0; n>0; n = n/10)
    {
        i = n%10; 
        sum = sum + i;
    }
    Console.WriteLine($"{sum}.");
}

numberSum(452);
numberSum(82);
numberSum(9012);