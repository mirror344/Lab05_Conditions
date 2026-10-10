Console.Write("Введите свой возраст: ");
int age = int.Parse(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine("Доступ разрешён");
}
else
{
    Console.WriteLine("Доступ запрещён");
}
