//Поиск наибольшего числа из 3 заданных.

int a, b, c, max;
a = 2;
b = 3;
c = 7;
max = a;

if (a==b& b==c) Console.WriteLine("Числа a, b и с равны.");
if (b>max) max = b;
if (c>max) max = c;  

Console.WriteLine($"Число {max} - наибольшее.");

a = 44;
b = 5;
c = 78;
max = a;

if (a==b& b==c) Console.WriteLine("Числа a, b и с равны.");
if (b>max) max = b;
if (c>max) max = c;  

Console.WriteLine($"Число {max} - наибольшее.");

a = 22;
b = 3;
c = 9;
max = a;

if (a==b& b==c) Console.WriteLine("Числа a, b и с равны.");
if (b>max) max = b;
if (c>max) max = c;  

Console.WriteLine($"Число {max} - наибольшее.");