Console.WriteLine("\t Добро пожаловать в приложении \" На пасеке \".\n  Для регистрации в приложении вам необходимо заполнить форму , а так же ввести логин и пароль.\n \t  Форма ");
Console.WriteLine(" Введите ваше имя");
var name = Console.ReadLine();
<<<<<<< HEAD
name=name.Trim();
=======
var nametrim = name.Trim(); // эта переменная не используется. Зачем она нужна?

/* 
 * 1. Названия переменных состоящих больше чем из 1 слова пишутся в PascalCase. Знаю что ты не знаешь что это. Гугли.
 * 2. Лишняя переменная, используется в одном месте, можно обойтись без неё
 */
var nametrimup = name.ToUpper(); // 

/* 1. Нужно уточнять что именно и в каком ввиде нужно вводить. У пользователя спрашивается 'день рождения', 
 *      а переменная, в которую сохраняется значние, называется year.
 *      Так что вводить: день или год рождения?
 *      В каком формате: 'дд:мм:гггг', просто число или какой-нибудь другой формат?
 * 2. Допустим нужно вводить год. Перемення year имеет тип string, т.е. пользователь введёт не год, а слово 'жопа', то программа будет работать как ни в чём не         бывало
 */
>>>>>>> 6ab49917c7a010efaa29ad97db94c64d42507e25
Console.WriteLine(" Введите ваш день рождения");
var year = Console.ReadLine();
Console.WriteLine("Требования к логину:\n * Логин должен быть миниму 3 символа и максимум 10\n * Логин не должен содержать Ваше имя\n * Если логин содержит цифры 5 или 7, то нужно заменить их словами.\n ");
Console.WriteLine(" Введите ваш логин");
var userlogin = Console.ReadLine();
userlogin = userlogin.Trim(); 
userlogin = userlogin.Replace("5", "пять").Replace("7", "семь");
<<<<<<< HEAD
if (userlogin.ToUpper().Contains(name.ToUpper()))
=======
var userlogup = userlogin.ToUpper(); // лишняя переменная, используется в одном месте, можно обойтись без неё
int dlinna = userlogin.Length; // лишняя переменная, используется в одном месте, можно обойтись без неё
if (userlogup.Contains(nametrimup))
>>>>>>> 6ab49917c7a010efaa29ad97db94c64d42507e25
{
    Console.WriteLine(" Ошибка! Логин не может содержать ваше имя");
    return; // А зачем завершать программу? Почему бы не зациклить? И идти дальше если пользователь ввёл согласно требованиям
}
else if (userlogin.Length < 3 || userlogin.Length > 10)
{
    Console.WriteLine(" Ошибка! Неверная длинна .\n Логин должен быть миниму 3 символа и максимум 10");
    return; // см коммент выше
}
else
{
    Console.WriteLine($" Ваш логин успешно сохранён \"{userlogin}\"");
}

Console.WriteLine("\t Требования к паролю:\n * Длинна пароля минимум 8 символов \n * Пароль не должен содержать Ваш день рождения \n * Пароль должен содержать один из этих символов !%*;$^ \n * Пароль не должен начинаться с русской буквы “п” или английской “p”\n \t Введите пароль");
<<<<<<< HEAD
var userpassword = Console.ReadLine();
int passwordlength = userpassword.Length;
=======
var userpassword = Console.ReadLine(); // PascalCase
int passwordlength = userpassword.Length; // Лишняя переменная, используется в одном месте, можно обойтись без неё
userpassword.Contains('!'); // эта строчка кода лишена смысла. Здесть проверяется есть ли в пароле '!', а с результатом этой проверки ничего не делается
>>>>>>> 6ab49917c7a010efaa29ad97db94c64d42507e25
if (passwordlength < 8)
{
    Console.WriteLine(" Ошибка! Неверная длина. \n Длинна пароля минимум 8 символов.");
    return;// программу можно зациклить
}
else if (userpassword.Contains(year))
{
    Console.WriteLine(" Ошибка! Пароль не должен содержать Ваш день рождения");
    return;// программу можно зациклить
}
else if (userpassword.StartsWith("п") || userpassword.StartsWith("p"))
{
    Console.WriteLine("Ошибка! Пароль не должен начинаться с русской буквы “п” или английской “p”");
    return;// программу можно зациклить
}
else if (userpassword.Contains('!') || userpassword.Contains('%') || userpassword.Contains('*') || userpassword.Contains(';') || userpassword.Contains('$') || userpassword.Contains('^'))
{
    Console.WriteLine($" Ваш пароль сохранён: {userpassword} ");
}
else
{
    Console.WriteLine(" Ошибка! Пароль должен содержать один из этих символов !%*;$^");
}
<<<<<<< HEAD
Console.WriteLine($" {name}, вы зарегистрированы в приложении \" На пасеке\". \n Ваш логин {userlogin} \n Ваш пароль {userpassword}");
=======
/* Здесь выводится последнее сообщение, и выводится оно должно только если пользователь всё ввёл по правилам.
 * Но это сообщение всё равно появляется если ввести неправильно пароль
 */
Console.WriteLine($" {name}, вы зарегистрированы в приложении \" На пасеке\". \n Ваш логин {userlogin} \n Ваш пароль {userpassword}");
// лишние пустые строки
// лишние пустые строки
// лишние пустые строки
// лишние пустые строки
>>>>>>> 6ab49917c7a010efaa29ad97db94c64d42507e25
