// Является ли число палиндромом
Console.Write("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine());
if (a.ToString().Length == 5)
{
    int a1 = a / 10000;
    int a2 = a / 1000 % 10;
    int a4 = a / 10 % 10;
    int a5 = a % 10;
    if (a1 == a5 && a2 == a4)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
        return;
    }
}
else
{
    Console.WriteLine("Число введено не корректно. Введите пятизначное число:");
    return;
}
