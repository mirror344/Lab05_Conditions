using System.Security.Cryptography.X509Certificates;

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// if (number > 0)
// {
//     System.Console.WriteLine("Число положительное.");
// }
// else if (number < 0)
// {
//     System.Console.WriteLine("Число отрицательное.");
// }
// else
// {
//     System.Console.WriteLine("Число равно нулю.");
// }

// Console.Write("Введите балл (0-100): ");
// int score = int.Parse(Console.ReadLine());
// if (score >= 91)
// {
//     System.Console.WriteLine("Оценка: Отлично (5)");
// }
// else if (score >= 71)
// {
//     System.Console.WriteLine("Оценка: Хорошо (4)");
// }
// else if (score >= 51)
// {
//     System.Console.WriteLine("Оценка: Удовлетворительно (3)");
// }
// else
// {
//     System.Console.WriteLine("Оценка: Неудовлетворительно (2)");
// }


// Console.Write("Введите количество посещений (из 19): ");
// int attendance = int.Parse(Console.ReadLine());
// Console.Write("Введите средний бал по практике:");
// double practiceGpa = double.Parse(Console.ReadLine());
// bool goodAttendance = attendance >= 14;
// bool goodGrades = practiceGpa >= 3.0;

// if (goodAttendance && goodGrades)
// {
//     System.Console.WriteLine("+ Доступ к экзамену разрешён.");
// }
// else if (!goodAttendance && goodGrades)
// {
//     System.Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
// }
// else if (goodAttendance && !goodGrades)
// {
//     System.Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
// }
// else
// {
//     System.Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к преподавателю.");
// }

Console.Write("Введите ваш возраст: ");
int age = int.Parse(Console.ReadLine());
string ageGroup = age >= 18 ? "совершеннолетний" : "несовершеннолетний";
System.Console.WriteLine($"Вы {ageGroup}.");

Console.Write("\nВведите температуру за окном (°C): ");
double temp = double.Parse(Console.ReadLine());
string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
Console.WriteLine($"За окном {weather}.");

Console.Write("\nВведите число: ");
int n = int.Parse(Console.ReadLine());
string parity = n % 2 == 0 ? "четное" : "нечетное";
System.Console.WriteLine($"Число {n} - {parity}.");

