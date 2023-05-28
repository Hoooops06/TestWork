Console.Clear(); // Clear
Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());

if (a < 100 || a > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    int b = a / 10;
    int n2 = b % 10;
    Console.WriteLine($"Второе число: {n2} ");
}

