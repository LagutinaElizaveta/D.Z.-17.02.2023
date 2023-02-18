// Является ли пятизначное число палиндромом
Console.Write("Введите пятизначное число: ");
string a = Console.ReadLine();
if (a.ToString().Length == 5)
{
    char[] palindrom = a.ToCharArray();
    if (palindrom[0] == palindrom[4] && palindrom[1] == palindrom[3])
    {
        Console.Write("Число является палиндромом");
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