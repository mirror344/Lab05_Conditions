Console.WriteLine("Вы попали в \"Темный лабиринт\". Найдите легендарного Dungeon Master’а!");
Console.WriteLine("Вам предстоит пройти через несколько комнат, каждая из которых может иметь свои опасности и сокровища");
Console.WriteLine("Чтобы продолжить, нажмите на любую клавишу...");
Console.ReadKey();
bool isGame = true;



while (isGame)
{
    Console.WriteLine("Вы стоите перед первой дверью. Перед вами два пути: \n Путь A \n Путь B");
    Console.Write("Выберите путь (1/2): ");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine("Вы выбрали путь А и встретили дракона!");
            Console.WriteLine("Дракон говорит: \n \"Кто не дышит, но живёт; хоть не нужно — много пьёт и вжизни, и в смерти тело как лёд.\"");
            Console.Write("Введите ответ на загадку: ");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "рыба")
            {
                Console.WriteLine("Вы ответили правильно! Дракон пропускает вас дальше.");
                continue;
            }
            else
            {
                Console.WriteLine("Неверный ответ! Дракон вас съел!");
                Console.WriteLine("Игра окончена. \nХотите сыграть снова? (ДА/НЕТ) :");
                string replay = Console.ReadLine();
                if (replay.ToLower() == "да")
                {
                    isGame = true;
                    continue;
                }
                else
                {
                    isGame = false;
                    Console.WriteLine("Спасибо за игру!");
                    break;
                }
            }
        case "2":
            Console.WriteLine("Вы выбрали Путь B и попали в тёмную комнату.");
            Console.WriteLine("В комнате 2 двери: \n Дверь 1 \n Дверь 2");
            Console.Write("Выберите дверь (1/2): ");
            string doorChoice = Console.ReadLine();
            switch (doorChoice)
            {
                case "1":
                    Console.WriteLine("Вы открыли первую дверь. За ней скрыты сокровища Dungeon Master’а!");
                    Console.WriteLine("Поздравляем! Вы нашли Dungeon Master’а и выиграли игру!");
                    isGame = false;
                    break;
                case "2":
                    Console.WriteLine("Вы открыли вторую дверь и попали в ловушку с ядовитыми шипами!");
                    Console.WriteLine("Вы не смогли выбраться и погибли.");

                    Console.WriteLine("Игра окончена. \nХотите сыграть снова? (ДА/НЕТ) :");
                    string replay = Console.ReadLine();
                    if (replay.ToLower() == "да")
                    {
                        isGame = true;
                        continue;
                    }
                    else
                    {
                        isGame = false;
                        Console.WriteLine("Спасибо за игру!");
                        break;
                    }
            }
           
            break;
        default:
            Console.WriteLine("Такого пути не существует. Попробуйте снова.");
            continue;
    }
}
