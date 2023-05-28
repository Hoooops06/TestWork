Console.Clear(); // Clear
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

while ( a < 1 || a > 7 )

{
    Console.Write("Такого дня недели нет.\nВведите день недели(от 1 до 7): ");
    a = int.Parse(Console.ReadLine()!);
}

if (a < 6)

Console.Write("Будний день");

else 
{
Console.Write("Выходной день");
}