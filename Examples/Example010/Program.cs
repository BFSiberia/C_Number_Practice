// выдает количество цифр в числе

int N = new Random().Next(1,10000);

int Qty(int N)
{   
    int i = 0;
    for(;N>0;i++)
    {
    N = N/10;
    }
    return i;
}
Console.WriteLine(N);
Console.WriteLine(Qty(N));

string z = Convert.ToString(new Random().Next(1,10000));
Console.WriteLine(z);
Console.WriteLine(z.Length);
