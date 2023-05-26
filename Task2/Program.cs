Console.Clear(); // Clear
Console.Write("Введите 1-ое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = int.Parse(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;

Console.Write("max = ");
Console.WriteLine(max);