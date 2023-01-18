//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//Функция ввода
int InNum (string message)
{
    Console.WriteLine(message);
    string? inVal = Console.ReadLine();
    int result = Convert.ToInt32(inVal);
    return result;
}

//Функция проверки того, что введено не меньше 3 знаков
bool Proverka(int number)
{
    if (number >99)
    {
    return true;
    }
    Console.WriteLine($"Ведённое Вами число {number} меньше трёх знаков");
    return false;
}


int number = InNum("Введите трёхзначное число =>");

//Обращение к функции проверки того, что введено не менее 3 знаков
if (Proverka(number))

//в случае введения числа больше 3 знаков, делает вывод имено третьего знака (не используя массивы)
    {
        if (number >=1000)
    {
       do
       {
        number = number/10;
       }
       while(number >=1000);
    }
    int endRank = (number%100)%10;
    Console.WriteLine($"Третьей цифрой введённого Вами числа является {endRank}");
    }
