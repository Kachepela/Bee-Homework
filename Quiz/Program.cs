Console.WriteLine("Викторина \"Кто хочет стать програмистом?\"");
Console.WriteLine("Нужно ответить на несколько вопросов. За каждый правильный ответ вы получаете 0.5 баллов");
Console.WriteLine("Постарайтесь набрать максимуму баллов");
Console.WriteLine("Нажмите enter чтобы начать");
Console.WriteLine(" За каждый правильный ответ вы получаете 0.5 баллов");
ConsoleKeyInfo input = Console.ReadKey();
Console.WriteLine();
while (input.Key != ConsoleKey.Enter)
{
    input = Console.ReadKey();
}
Console.Clear();
Console.WriteLine("Вопрос #1");
Console.WriteLine("Кого принято считать первым программистом?");
Console.WriteLine("1 - Ада Лавлейс");
Console.WriteLine("2 - Элфрид Аннун");
Console.WriteLine("3 - Астор Карр");
Console.WriteLine("4 - Кристоф Александер");
double score = 0.0;
double score2 = 0.5;
int answer = 0;
int scoreSum = 0;
while (!int.TryParse(Console.ReadLine(), out answer) || answer < 1 || answer > 4)
    Console.WriteLine("Вы ввели неверное значение");
if (answer == 1)
{
    score += score2;
    ++scoreSum;
}
Console.Clear();
Console.WriteLine("Вопрос #2");
Console.WriteLine("Какого языка программирования не существует?");
Console.WriteLine("1 - Go");
Console.WriteLine("2 - Perl");
Console.WriteLine("3 - C+");
Console.WriteLine("4 - Haskel");
Console.WriteLine("5 - F#");
while (!int.TryParse(Console.ReadLine(), out answer) || answer < 1 || answer > 5)
    Console.WriteLine("Вы ввели неверное значение");
if (answer == 3)
{
    score += score2;
    ++scoreSum;
}
Console.Clear();
Console.WriteLine("Вопрос #3");
Console.WriteLine("Как называется алгоритм, который на каком-либо шаге обращается сам к себе?");
Console.WriteLine("1 - Циклическим");
Console.WriteLine("2 - Вспомогательным");
Console.WriteLine("3 - Самоссылащимся");
Console.WriteLine("4 - Рекурсивным");
while (!int.TryParse(Console.ReadLine(), out answer) || answer < 1 || answer > 4)
    Console.WriteLine("Вы ввели неверное значение");
if (answer == 4)
{
    score += score2;
    ++scoreSum;
}
Console.Clear();
Console.WriteLine("Викторина окончена.");
Console.WriteLine("3 вопроса, правильных ответов - " + scoreSum.ToString());
Console.WriteLine("Набрано " + score.ToString() + " баллов");
Console.ReadKey();
