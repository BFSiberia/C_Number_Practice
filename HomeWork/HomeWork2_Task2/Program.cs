int number = new Random().Next(100,999);
Console.WriteLine($"Исходное число: {number}.");

Console.Write($"Итоговое число: {number/100}{number %10}.");