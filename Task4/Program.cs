Console.Write("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int num_3 = int.Parse(Console.ReadLine());
int sum = 0;

if (num_1 >= 0)
{
    sum += num_1;
}
if (num_2 >= 0)
{
   sum += num_2; 
}
if (num_3 >= 0)
{
   sum += num_3; 
}

Console.WriteLine($"Сумма чисел: {sum}");