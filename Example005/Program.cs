int x,y,section;

Console.WriteLine("Введите точку по оси x: ");
x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите точку по оси y: ");
y = int.Parse(Console.ReadLine());

while(x==0^ y==0)
{
    Console.WriteLine("Точка координат не может равняться 0: ");
    Console.WriteLine("Введите точку по оси x: ");
    int.Parse(Console.ReadLine());
    Console.WriteLine("Введите точку по оси y: ");
    int.Parse(Console.ReadLine());
}
if(x>0&y>0) 
{section =1;
Console.WriteLine($"Номер четверти {section}");
}
if(x>0&y<0) 
{section =2;
Console.WriteLine($"Номер четверти {section}");
}
if(x<0&y<0)
{section =3;
Console.WriteLine($"Номер четверти {section}");
}
if(x<0&y>0) 
{section =4;
Console.WriteLine($"Номер четверти {section}");
}