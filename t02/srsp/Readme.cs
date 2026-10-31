using System;

Console.Write("Укажите неотрицательное целое число n: ");
string? rawInput = Console.ReadLine();

if (!int.TryParse(rawInput, out int n) || n < 0)
{
    Console.WriteLine("Ошибка ввода: необходимо ввести целое число не меньше 0.");
}
else
{
    int digitSum = 0;
    int digitCount = 0;

    do
    {
        n = Math.DivRem(n, 10, out int lastDigit);
        digitSum += lastDigit;
        digitCount++;
    }
    while (n > 0);

    Console.WriteLine($"Цифр в числе: {digitCount}");
    Console.WriteLine($"Сумма цифр: {digitSum}");
}