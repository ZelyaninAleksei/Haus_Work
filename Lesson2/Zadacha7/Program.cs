/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

//Функция приглашения ввода 
int NumberDay(string message)
{
    Console.WriteLine(message);
    string? inVal = Console.ReadLine();
    int result = Convert.ToInt32(inVal);
    return result;
}

//Функция проверки "день недели или нет"
bool Week(int inputNumDay)
{
    return (inputNumDay <= 7 && inputNumDay > 0);
}

//Функция проверки на выходной день (6 или 7)
bool WeekEnd(int inputNumDay)
{
    return (inputNumDay == 7 || inputNumDay == 6);
}

int num_d = NumberDay("Введите номер дня недели =>");

if (Week(num_d))
{
    if (WeekEnd(num_d))
    {
        Console.WriteLine($"Введенный Вами день {num_d} - выходной");
    }
    else
    {
        Console.WriteLine($"Введенный Вами день {num_d} - рабочий");
    }
}
else
{
    Console.WriteLine($"Введенный Вами день недели {num_d} - некорректный");
}