int a = 645;
int b = 78;
int c = 32679;

int number = a;
Console.WriteLine($"Число: {number}.");
if(number < 100) Console.WriteLine($"У числа {number}, третьей цифры нет.");
else Console.WriteLine($"Третья цифра: {(number%1000)/100}.");

number = b;
Console.WriteLine($"Число: {number}.");
if(number < 100) Console.WriteLine($"У числа {number}, третьей цифры нет.");
else Console.WriteLine($"Третья цифра: {(number%1000)/100}.");

number = c;
Console.WriteLine($"Число: {number}.");
if(number < 100) Console.WriteLine($"У числа {number}, третьей цифры нет.");
else Console.WriteLine($"Третья цифра: {(number%1000)/100}.");