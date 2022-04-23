int[] source = {14212, 12821, 23432};

for(int i=0; i<source.Length; i++)
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
}
