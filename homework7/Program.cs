﻿Console.Clear();
int Prompt(string msg)
{
    Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");
string ss = "Это не день недели";
string check(int number)
{
    if (number >= 6 && number < 8)
    ss = "Это выходной";
    if (number >= 1 && number < 6)
    ss = "Это будний день";
    return ss;
}

Console.WriteLine(check(number));