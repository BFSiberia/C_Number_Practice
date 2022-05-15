// Напишите программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями y = k1*x+b1 и y = k2*x+b2.
// значениия b1 k1 b2 k2 задаются пользователем. (-0.5;5.5)

double x=0;
double y=0;
Console.Write("Введите через пробел пару чисел k1 и b1 для первого уравнения y = k1*x+b1: ");
string input1 = Console.ReadLine();
string[] array1 = input1.Split(" ");
double k1 = double.Parse(array1[0]);
double b1 = double.Parse(array1[1]);

Console.Write("Введите через пробел пару чисел k2 и b2 для второго уравнения y = k2*x+b2: ");
string input2 = Console.ReadLine();
string[] array2 = input2.Split(" ");
double k2 = double.Parse(array2[0]);
double b2 = double.Parse(array2[1]);

if ((k1*-1-k2*-1)==0)
Console.WriteLine("Прямые параллельны.");
else if (k2/k1==-1/-1 && -1/-1==b2/b1)
Console.WriteLine("Прямые совпадают.");
else
{
    x = -((b1*-1-b2*-1)/(k1*-1-k2*-1));
    y = k2*x + b2;
    Console.WriteLine($"Координаты точки пересечения прямых: {x} и {y}.");
}