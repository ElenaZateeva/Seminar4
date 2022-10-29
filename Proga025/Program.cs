// На входе 2 числа А и В. Возведение в степень В числа А.
Console.WriteLine("Возведем в степень число А. Введите его:");
bool isParsedA = int.TryParse(Console.ReadLine(), out int A);
Console.WriteLine("Введите число степени:");
bool isParsedB = int.TryParse(Console.ReadLine(), out int B);

if (!isParsedA || !isParsedB)
{
    Console.WriteLine("ОШИБКА ввода данных А и В!");
    return;
}
int exponent = ExponentionNumber(A, B);
Console.WriteLine($"Результат возведени в степень: {exponent}");

int ExponentionNumber(int a, int b)
{
    int result =a;
    for (int i = 1; i < B; i++)
    {
        result = result*a;
    }
    return result;
}