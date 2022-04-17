Console.Write("Введите номер четверти от 1 до 4: ");
int section = int.Parse(Console.ReadLine());

if (section == 1) Console.WriteLine("Диапазон координат x от 1 до +бесконечности, y от 1 до +бесконечности.");
else if (section == 2) Console.WriteLine("Диапазон координат x от 1 до +бесконечности, y от -1 до -бесконечности.");
else if (section == 3) Console.WriteLine("Диапазон координат x от -1 до -бесконечности, y от -1 до -бесконечности.");
else if (section == 4) Console.WriteLine("Диапазон координат x от 1 до +бесконечности, y от 1 до -бесконечности.");
else if (section >=0 & section<5) Console.WriteLine("Номер четверти должен быть в диапазоне от 1 до 4.");