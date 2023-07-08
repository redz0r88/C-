Console.Clear();
int max = 0;
Console.Write("Введите числа");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
int SecondNumber = Convert.ToInt32(Console.ReadLine());
int ThirdNumber = Convert.ToInt32(Console.ReadLine());

if (FirstNumber > max)
{
    max = FirstNumber;
}
if (SecondNumber > max)
{
max = SecondNumber;
}
if (ThirdNumber > max)
{
max = ThirdNumber;
}
Console.WriteLine("Максимальное значение" + " " + "=" + " " + max);