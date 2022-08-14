/*Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/


int x = ReadInt("Введите координату Х: ");
int y = ReadInt("Введите координату Y: ");

if(x == 0 || y == 0)
{
    Console.WriteLine("Четверти определить невозможно");
    return;
}
if(x > 0 && y > 0)
{
    Console.WriteLine("Первая четверть");
}
else if(x < 0 && y > 0 )
{
     Console.WriteLine("Вторая четверть");
}
else if(x < 0 && y < 0 )
{
     Console.WriteLine("Третья четверть");
}
else if(x > 0 && y < 0 )
{
     Console.WriteLine("Четвертая четверть");
}


int ReadInt(string message)
{
     Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

