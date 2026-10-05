using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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

// Console.Write("Введите ваш возраст: ");
// int age = int.Parse(Console.ReadLine());
// string ageGroup = age >= 18 ? "совершеннолетний" : "несовершеннолетний";
// System.Console.WriteLine($"Вы {ageGroup}.");

// Console.Write("\nВведите температуру за окном (°C): ");
// double temp = double.Parse(Console.ReadLine());
// string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
// Console.WriteLine($"За окном {weather}.");

// Console.Write("\nВведите число: ");
// int n = int.Parse(Console.ReadLine());
// string parity = n % 2 == 0 ? "четное" : "нечетное";
// System.Console.WriteLine($"Число {n} - {parity}.");

// System.Console.WriteLine("Меню");
// System.Console.WriteLine("1. Посмотреть расписание");
// System.Console.WriteLine("2. Посмотреть оценки");
// System.Console.WriteLine("3. Связаться с преподавателем");
// System.Console.WriteLine("4. Выйти");
// Console.Write("Выберите пункт (1-4): ");
// string choice = Console.ReadLine();
// switch (choice)
// {
//     case "1":
//         System.Console.WriteLine("Расписание: ИСП-244, каб. 102, 08:30");
//         break;
//     case "2":
//         System.Console.WriteLine("Ваши оценки: ИРСПО - 20, РПМ - 35");
//         break;
//     case "3":
//         System.Console.WriteLine("Email: denis.leontev922yandex.ru");
//         break;
//     case "4":
//         System.Console.WriteLine("До свидания!");
//         break;
//     default:
//         System.Console.WriteLine($"Ошибка: пункт {choice} не существует. Введите число от 1 до 4.");
//         break;
// }


// Console.Write("\nВведите номер дня недели (1-7): ");
// int dayNumber = int.Parse(Console.ReadLine());
// switch (dayNumber)
// {
//     case 1:
//     case 2:
//     case 3:
//     case 4:
//     case 5:
//         System.Console.WriteLine("Рабочий день - пора учиться!");
//         break;
//     case 6:
//     case 7:
//         System.Console.WriteLine("Выходной - заслуженный отдых.");
//         break;
//     default:
//         System.Console.WriteLine("Такого дня не существует.");
//         break;
// }

// Console.Write("\nВведите номер месяца (1-12): ");
// int month = int.Parse(Console.ReadLine());
// switch (month)
// {
//     case 12:
//     case 1:
//     case 2:
//         System.Console.WriteLine("Зима");
//         break;
//     case 3:
//     case 4:
//     case 5:
//         System.Console.WriteLine("Весна");
//         break;
//     case 6:
//     case 7:
//     case 8:
//         System.Console.WriteLine("Лето");
//         break;
//     case 9:
//     case 10:
//     case 11:
//         System.Console.WriteLine("Осень");
//         break;
//     default:
//         System.Console.WriteLine("Такого месяца не существует.");
//         break;
// }


Random random = new Random();
int secret = random.Next(1, 101);
int attempts = 0;
bool guessed = false;

Console.WriteLine("Угадайте число (1-100)");
Console.WriteLine("Я загадал число. Попробуй угадать!");





string GetHint(int difference)
{
    switch (difference)
    {
        case <= 3:
            return "🔥 Горячо!";
        case <= 10:
            return "🌡 Тепло.";
        case <= 25:
            return "🌀 Прохладно";
        default:
            return "❄ Холодно!";
    }
}

while (!guessed)
{
    Console.Write($"Попытка {attempts + 1}. Твой вариант: ");
    string input = Console.ReadLine();
    if (!int.TryParse(input, out int guess))
    {
        Console.WriteLine("!!! Введите число, а не текст!");
        continue;
    }

    if (guess < 1 || guess > 100)
    {
        Console.WriteLine("!!! Число должно быть от 1 до 100!");
        continue;
    }

    attempts++;

    if (guess < secret)
    {
        int diff = secret - guess;
        string hint = GetHint(diff);
        Console.WriteLine($"↑ Больше! {hint} \n");
    }
    else if (guess > secret)
    {
        int diff = guess - secret;
        string hint = GetHint(diff);
        Console.WriteLine($"↓ Меньше! {hint} \n");
    }
    else
    {
        guessed = true;
        

    }
}

string result = attempts <= 7 
? $"Отличный результат! Всего {attempts} попыток." 
: $"Число найдено за {attempts} попыток. Можно лучше!";

Console.WriteLine($"🎉 Правильно! Загаданное число: {secret}");
Console.WriteLine($"{result}");

