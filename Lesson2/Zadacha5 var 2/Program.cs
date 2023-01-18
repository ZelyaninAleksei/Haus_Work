//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//Вариант 2 "С использованием функций"

int InputNumb(string message)
{
    Console.WriteLine(message);
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

bool Proverka(int number)
{
    if (number > 99 && number < 1000)
    {
        return true;
    }
    Console.WriteLine($"Введённое число {number} не является трёхзначным");
    return false;
}

int number = InputNumb("Введите трёхзначное число =>");
if (Proverka(number))
{
int SecondRank = (number%100)/10;
Console.WriteLine($"Вторая цифра введённого числа {number} равняется {SecondRank} ");
}