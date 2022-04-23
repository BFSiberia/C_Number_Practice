// выдает количество цифр в числе

int N = new Random().Next(1,1000);

int Qty(int N)
{
    int length = 0;
    for(int i=1;N>0;i++)
    {
    N = N/10;
    length += 1;
    }
return length;
}
Console.WriteLine(N);
Console.WriteLine(Qty(N));

