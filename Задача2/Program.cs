// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int number = ReadInt("Введите номер четверти: ");


if(number > 4 || number ==0 || number < 0)
{
    Console.WriteLine("Такой четверти не существует");
    return;
}
if(number == 1)
{
    Console.WriteLine("Возможные координаты x > 0 , y > 0"); 
}
else if(number == 2 )
{
     Console.WriteLine("Возможные координаты x < 0 , y > 0");
}
else if(number == 3 )
{
     Console.WriteLine("Возможные координаты x < 0 , y < 0");
}
else if(number == 4 )
{
     Console.WriteLine("Возможные координаты x > 0 , y < 0");
}


int ReadInt(string message)
{
     Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}