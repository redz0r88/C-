Console.Clear();
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов: ");
for (int i=1;i<=n;i++)
{
int k = i*i*i;
Console.Write($"{k}, ");
}