Console.WriteLine("\t Добро пожаловать в приложении \" На пасеке \".\n  Для регистрации в приложении вам необходимо заполнить форму , а так же ввести логин и пароль.\n \t  Форма ");
Console.WriteLine(" Введите ваше имя");
var name = Console.ReadLine();
var nametrim = name.Trim();
var nametrimup = name.ToUpper();
Console.WriteLine(" Введите ваш день рождения");
var year = Console.ReadLine();
Console.WriteLine("Требования к логину:\n * Логин должен быть миниму 3 символа и максимум 10\n * Логин не должен содержать Ваше имя\n * Если логин содержит цифры 5 или 7, то нужно заменить их словами.\n ");
Console.WriteLine(" Введите ваш логин");
var userlogin = Console.ReadLine();
userlogin = userlogin.Replace("5", "пять").Replace("7", "семь");
var userlogup = userlogin.ToUpper();
int dlinna = userlogin.Length;
if (userlogup.Contains(nametrimup))
{
    Console.WriteLine(" Ошибка! Логин не может содержать ваше имя");
    return;
}
else if (dlinna < 3 || dlinna > 10)
{
    Console.WriteLine(" Ошибка! Неверная длинна .\n Логин должен быть миниму 3 символа и максимум 10");
    return;
}
else
{
    Console.WriteLine($" Ваш логин успешно сохранён \"{userlogin}\"");
}

Console.WriteLine("\t Требования к паролю:\n * Длинна пароля минимум 8 символов \n * Пароль не должен содержать Ваш день рождения \n * Пароль должен содержать один из этих символов !%*;$^ \n * Пароль не должен начинаться с русской буквы “п” или английской “p”\n \t Введите пароль");
var userpassword = Console.ReadLine();
int passwordlength = userpassword.Length;
userpassword.Contains('!');
if (passwordlength < 8)
{
    Console.WriteLine(" Ошибка! Неверная длина. \n Длинна пароля минимум 8 символов.");
    return;
}
else if (userpassword.Contains(year))
{
    Console.WriteLine(" Ошибка! Пароль не должен содержать Ваш день рождения");
    return;
}
else if (userpassword.StartsWith("п") || userpassword.StartsWith("p"))
{
    Console.WriteLine("Ошибка! Пароль не должен начинаться с русской буквы “п” или английской “p”");
    return;
}
else if (userpassword.Contains('!') || userpassword.Contains('%') || userpassword.Contains('*') || userpassword.Contains(';') || userpassword.Contains('$') || userpassword.Contains('^'))
{
    Console.WriteLine($" Ваш пароль сохранён: {userpassword} ");
}
else
{
    Console.WriteLine(" Ошибка! Пароль должен содержать один из этих символов !%*;$^");
}
Console.WriteLine($" {name}, вы зарегистрированы в приложении \" На пасеке\". \n Ваш логин {userlogin} \n Ваш пароль {userpassword}");



