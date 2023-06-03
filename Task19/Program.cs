Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 9999 || n > 100000)
{
    Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
    n = int.Parse(Console.ReadLine()!);
}
string number = n.ToString();
if (number[0] == number[4] && number[1] == number[3])
Console.Write($"Число {n} является палиндромом");
else
    Console.Write($"Число {n} не является палиндромом");
