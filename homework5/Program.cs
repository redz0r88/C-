Console.Clear();
Console.WriteLine("Напишите трёхзначное число");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 99 && n < 1000)
{
    int n1 = (n % 100 - n % 10) / 10;
    Console.WriteLine($"Вторая цифра числа {n} является {n1}");
}