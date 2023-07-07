
Console.Clear();
Console.WriteLine("Введите числа");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > max) 
max = b;

Console.WriteLine("Максимальное" + " " + max);