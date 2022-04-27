// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
//SysCoord = new int[] {3, 6, 8, 2, 1, -7};
//SysCoord = new int[] {7, -5, 0, 1, -1, 9};

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

double distance = Math.Sqrt(Math.Pow(SysCoord[0]-SysCoord[3],2)+ Math.Pow(SysCoord[1]-SysCoord[4],2)+Math.Pow(SysCoord[2]-SysCoord[5],2));

Console.WriteLine($"Координаты точки 1: {SysCoord[0]},{SysCoord[1]},{SysCoord[2]}");
Console.WriteLine($"Координаты точки 2: {SysCoord[3]},{SysCoord[4]},{SysCoord[5]}");

Console.WriteLine($"Растояние между точками: {distance}.\n");

// Решение задачи с использованием двумерных массивов и циклов while

int[,] RndCoords (int[,]generate)
{
    int i = 0;
    while(i<generate.GetLength(0))
    {
        int j =0;
        while(j<generate.GetLength(1))
        {
            generate[i,j] = new Random().Next(-10,10);
            j++;
        }
        i++;
    }
    return generate;
}

void PrintCoords(int [,] coord)
{
    int i =0;
    while(i<coord.GetLength(0))
    {
        int j =0;
        Console.Write($"Координаты точки {i+1}: ");
        while(j<coord.GetLength(1))
        {
            Console.Write(coord[i,j]+" ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

int[,] SysCoord1 = new int[2,3];

PrintCoords(RndCoords(SysCoord1));
double distance1 = Math.Sqrt(Math.Pow(SysCoord1[0,0]-SysCoord1[1,0],2)+ Math.Pow(SysCoord1[0,1]-SysCoord1[1,1],2)+Math.Pow(SysCoord1[0,2]-SysCoord1[1,2],2));
Console.WriteLine($"Растояние между точками: {distance1}.\n");

