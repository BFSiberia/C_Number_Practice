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

int[] SysCoord = new int[4];
    
RndCoord(SysCoord);

double distance = Math.Sqrt(Math.Pow(SysCoord[0]-SysCoord[2],2)+ Math.Pow(SysCoord[1]-SysCoord[3],2));

Console.WriteLine($"Координаты точки 1: {SysCoord[0]},{SysCoord[1]}");
Console.WriteLine($"Координаты точки 2: {SysCoord[2]},{SysCoord[3]}");
Console.WriteLine($"Растояние между точками: {distance}.");