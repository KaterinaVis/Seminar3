// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

//Со SWITCH

int number = ReadInt("Введите номер четверти: ");

switch(number)
{
    case 1:
    Console.WriteLine("Возможные координаты x > 0 , y > 0");
    break;

    case 2:
    Console.WriteLine("Возможные координаты x < 0 , y > 0");
    break;

    case 3:
    Console.WriteLine("Возможные координаты x < 0 , y < 0");
    break;

    case 4:
    Console.WriteLine("Возможные координаты x > 0 , y < 0");
    break;

    default:
    Console.WriteLine("Такой четверти не существует");
    break;
}

// функция

int ReadInt(string message)
{
     Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}