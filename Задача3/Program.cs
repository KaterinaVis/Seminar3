/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */

int pointAx = ReadInt("Введите координату Х точки А: ");
int pointAy = ReadInt("Введите координату Y точки А: ");
int pointBx = ReadInt("Введите координату Х точки В: ");
int pointBy = ReadInt("Введите координату Y точки В: ");

int lineA = pointAx - pointBx;
int lineB = pointAy - pointBy;
double length = Math.Sqrt(lineA*lineA + lineB*lineB);

    Console.WriteLine(length);
    return;


int ReadInt(string message)
{
     Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
