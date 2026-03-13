Random random = new Random();
Console.Write("Пожалуста, введите число: ");
int number;
while(!int.TryParse(Console.ReadLine(), out  number))
{
    Console.Write("Пожалуйста, введите корректное число: ");
}
bool IsEven = number % 2 == 0;
Console.WriteLine($"Число {number} — {(IsEven ? "четное" : "нечетное")}.");
Console.WriteLine("=======================================");
Console.Write("Введите температуру (°C): ");
double temp;
while(!double.TryParse(Console.ReadLine(), out  temp))
{
    Console.Write("Пожалуйста, введите корректную температуру: ");
}
string s=string.Empty;
if(temp<0)
{
    s="Очень холодно! Надень пуховик, шапку, шарф";
}
else if (temp<10)
{
    s="Холодно. Тёплая куртка обязательна";
}
else if(temp<20)
{
    s="Прохладно. Лёгкая куртка или свитер";
}
else if(temp<30)
{
    s="Комфортно. Можно в футболке";
}
else
{
    s="Жара! Бери воду и крем от загара";
}
if(string.IsNullOrEmpty(s))
{
    s="Error";
}
Console.WriteLine(s);
Console.WriteLine("=============================================");
double a=0;
const int total=5;
double all=0;
 string otsenki=string.Empty;
    string status=string.Empty;
while(a<total)
{
    
    Console.Write($"Введите оценку {a + 1}: ");
    a++;
    int ocenki;
   
    while(!int.TryParse(Console.ReadLine(), out  ocenki)||ocenki<0||ocenki>5)
    {
        Console.Write("Пожалуйста, введите корректное число: ");
    }
    all+=ocenki;
}
all/=(double)total;
a=0;
Console.Write($"Средняя оценка: {all}");
all=Math.Round(all,MidpointRounding.AwayFromZero);
otsenki=all switch
{
    5=>"Отлично",
    4=>"Хорошо",
    3=>"Удовлетворительно",
    2=>"Неудовлетворительно",
    _=>"Неудовлетворительно"
};
Console.WriteLine($" → {otsenki}");
status=otsenki switch
{
    "Отлично"=>"Поздравляем!",
    "Хорошо"=>"Неплохо, можно лучше",
    "Удовлетворительно"=>"На троечку прошёл",
    "Неудовлетворительно"=>"Надо подтянуть предмет",
    _=>"Error"
};
Console.WriteLine(status);
Console.WriteLine("=============================================");

int popitki=0;
Console.WriteLine("Добро пожаловать в игру «Угадай число»!");
Console.WriteLine("Выберите уровень сложности: ");
Console.WriteLine("1. Лёгкий (10 попыток)");
Console.WriteLine("2. Средний (7 попыток)");
Console.WriteLine("3. Сложный (5 попыток)");
int choice;
Console.Write("Введите уровень сложности: ");
string level=Console.ReadLine();
level=level.Trim().ToLower();
choice=level switch
{
    "1" or "легкий" or "легко" => 10,
    "2" or "средний" or "средне" => 7,
    "3" or "сложный" or "сложно" => 5,
    _ => -1
};

if (choice == -1)
{
    Console.WriteLine("Некорректный уровень сложности.");
    return;
}
int life=choice;
int randomNumber = random.Next(1, 101);
while(popitki<life)
{
    Console.Write("Угадайте число от 1 до 100: ");
    int userGuess;
    while(!int.TryParse(Console.ReadLine(), out  userGuess)||userGuess<1||userGuess>100)
    {
        Console.Write("Пожалуйста, введите корректное число от 1 до 100: ");
    }
    popitki++;
    if(userGuess==randomNumber)
    {
        Console.WriteLine($"Поздравляем! Вы угадали число {randomNumber} за {popitki} попыток.");
        break;
    }
    else if(userGuess<randomNumber)
    {
        Console.WriteLine($"Слишком маленькое число. Попробуйте снова. Осталось попыток: " + (life - popitki));
    }
    else
    {
        Console.WriteLine($"Слишком большое число. Попробуйте снова. Осталось попыток: " + (life - popitki));
    }
    if(popitki==life)
    {
        Console.WriteLine($"К сожалению, вы исчерпали все попытки. Загаданное число было: {randomNumber}");
        break;
    }
}

