int[] source = {14212, 12821, 23432};
int length = source.Length;
int i = 0;

while(i<length)
{
    int number = source[i];
    int result = 0;
    
        while (number>0)
        {
            result = result *10 + number%10;
            number /= 10;
        }
    if (source[i] == result) Console.WriteLine($"Да, число {source[i]} палиндром.");
    else Console.WriteLine($"Нет, число {source[i]} не палиндром.");
    i++;
}
