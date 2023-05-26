Console.Clear(); // Clear
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 1)
{
    Console.WriteLine($"Число: {a} нечетное");
}

else
{
    Console.WriteLine($"Число: {a} четное");
}
