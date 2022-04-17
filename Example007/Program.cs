// int[] coordinates = {1,2};

int coordinates = x1, x2, y1,y2;
x1 = new Random().Next(-10,10);
x2 = new Random().Next(-10,10);
y1 = new Random().Next(-10,10);
y2 = new Random().Next(-10,10);
double distance = Math.Sqrt(Math.Pow(x1-x2,2)+ Math.Pow(y1-y2,2));
Console.WriteLine($"Растояние между точками: {distance}.");