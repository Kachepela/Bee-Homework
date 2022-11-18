Console.WriteLine("  \t Игра угадайка.\n Угадайте случайное число от 1 до 500");
int secret = new Random().Next(1, 500);
Console.WriteLine("Введите число");
int number;
int.TryParse(Console.ReadLine(), out number);

if (secret==number )
{
    Console.WriteLine(" Поздравляем! Вы угадали. ");
}
else if (number<0 || number > 500)
{
            Console.WriteLine("Ошибка.Вы ввели не верное значение. ВВедите цифру от 1 до 500.");
}
else
{
    Console.WriteLine("Иии...барабанная дробь\n  Вы не угадали. ");
} 
    


