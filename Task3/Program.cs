Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите знак (+ - * /): ");
string operation = Console.ReadLine();

switch (operation)
{
    case "+":
        Console.WriteLine($"Сумма: {x + y}");
        break;
    case "-":
        Console.WriteLine($"Разность: {x - y}");
        break;
    case "*":
        Console.WriteLine($"Произведение: {x * y}");
        break;
    case "/":
        Console.WriteLine($"Деление: {(double)x / y}");
        break;
    default:
        Console.WriteLine("Такого знака нет");
        break;
}
