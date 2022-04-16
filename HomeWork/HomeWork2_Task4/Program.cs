string question = "Введите номер дня недели от 1 до 7, чтобы узнать выходной ли это день: ";
string incorrect = "Введен не верный номер дня недели!\nПовторите ввод.";
string yes = "Да, это выходной день!";
string no = "Нет. это будний день.";

Console.Write(question);
int weekDay = int.Parse(Console.ReadLine());

while(weekDay<1^weekDay>7)
{
    Console.WriteLine(incorrect);
    Console.Write(question);
    weekDay = int.Parse(Console.ReadLine());
}
if(weekDay<6) Console.WriteLine(no);
else Console.WriteLine(yes);