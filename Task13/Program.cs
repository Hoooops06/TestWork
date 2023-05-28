Console.Clear(); // Clear
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a < 100)
    Console.Write("Третьей цифры нет");
else
{
    while (a > 999)
        a = a / 10;
    Console.Write($"{a % 10}");
}