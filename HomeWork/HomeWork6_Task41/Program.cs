// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.

Console.WriteLine("Введите числа через пробел, по зверешению нажмите Ввод: ");
string list = Console.ReadLine();
string[] array = list.Split(" ");

int count =0;
for (int i = 0; i<array.Length; i++)
{
if (int.Parse(array[i]) >0) count = count +1;
}
Console.WriteLine("Количество чисел больше 0: "+count);