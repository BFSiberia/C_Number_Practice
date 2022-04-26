// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

void RndCoord (int[]generate)
{
    int length = generate.Length;
    int index = 0;
    while(index<length)
    {
        generate[index] = new Random().Next(-10,10);
        index++;
    }
}

int[] SysCoord = new int[6];
    
RndCoord(SysCoord);

//SysCoord = new int[] {3, 6, 8, 2, 1, -7};
//SysCoord = new int[] {7, -5, 0, 1, -1, 9};

double distance = Math.Sqrt(Math.Pow(SysCoord[0]-SysCoord[3],2)+ Math.Pow(SysCoord[1]-SysCoord[4],2)+Math.Pow(SysCoord[2]-SysCoord[5],2));

Console.WriteLine($"Координаты точки 1: {SysCoord[0]},{SysCoord[1]},{SysCoord[2]}");
Console.WriteLine($"Координаты точки 2: {SysCoord[3]},{SysCoord[4]},{SysCoord[5]}");

Console.WriteLine($"Растояние между точками: {distance}.");