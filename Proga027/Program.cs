// На входе число. На выходе сумма цифр данного числа
Console.WriteLine("Введите любое число:");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);

if (!isParsedA)
{
    Console.WriteLine("ОШИБКА ввода данных!");
    return;
}

if (a < 0)
{
    Console.WriteLine("0");
    return;
}

int summa = SumOfDigits(a);
Console.WriteLine($"Сумма цифр из заданного числа: {summa}");

int SumOfDigits(int a)
{
    int sum = 0, ost = 0;
    while (a > 0)
    {
        ost = a % 10;
        a = a / 10;
        sum = sum + ost;
    }
    return sum;
}

