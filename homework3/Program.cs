﻿Console.Clear();
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("Четное число");
}
else 
{
    Console.WriteLine("Нечетное число");
}