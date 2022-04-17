int number;
int i = 1;

number = 0;

if (number == 0)
{
    Console.WriteLine("Ноль");
}
while(i<=Math.Abs(number))
{
    Console.WriteLine(Math.Pow(i,2));
    i++;
}
