/*Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */

int number = ReadInt("Введите число: ");
int count =1;

while(count < number)
{
Console.Write(Sqr(count) + ",");
count++; 
if (count == number) // избавляемся от точки и запятой в конце
{
    Console.Write(Sqr(count) + " ");
}
}


int ReadInt(string message) // функция
{
     Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Sqr(int num1)  // функция
{
    return num1 * num1;
}