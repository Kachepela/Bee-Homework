Console.WriteLine("  \t Игра угадайка.\n Угадайте случайное число от 1 до 500");
int secret = new Random().Next(1, 500);
Console.WriteLine("Введите число");
int number;

while (true)
    { if (!int.TryParse(Console.ReadLine(), out number))
    {
        continue;
    }
    if (secret == number)
    {
        Console.WriteLine(" Поздравляем! Вы угадали. ");
        break;
    }
     if (number < 0 || number > 500)
    {
        Console.WriteLine("Ошибка.Вы ввели не верное значение. Введите цифру от 1 до 500.");
    }
    else
    {
        Console.WriteLine("Иии...барабанная дробь\n  Вы не угадали. ");
    }
     if (secret>number)
    {
        Console.WriteLine("Загаданое число больше ,чем то что вы ввели.");
    }
     if (secret < number)
    {
        Console.WriteLine(" Загаданное число меньше , чем вы ввели. ");
    }
}
Console.ReadKey();


