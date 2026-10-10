Console.WriteLine("Введите пароль:");
string password = Console.ReadLine();
Console.WriteLine("Подтвердите пароль:");
string confirmation = Console.ReadLine();

if (confirmation == password)
{
    Console.WriteLine("Пароль принят");
}

else
{
    Console.WriteLine("Пароль не принят");
}
