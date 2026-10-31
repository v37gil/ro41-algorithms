using System;

Console.Write("Введите значение a (a >= 0): ");
string? strA = Console.ReadLine();

Console.Write("Введите значение b (b >= 0): ");
string? strB = Console.ReadLine();

bool isValidA = int.TryParse(strA, out int a) && a >= 0;
bool isValidB = int.TryParse(strB, out int b) && b >= 0;

if (!isValidA || !isValidB)
{
    Console.WriteLine("Ошибка: требуются целые неотрицательные числа.");
}
else if (a == 0 && b == 0)
{
    Console.WriteLine("Ошибка: числа a и b не должны быть равны 0 одновременно.");
}
else
{
    while (b != 0)
    {
        int r = a % b;
        a = b;
        b = r;
    }

    Console.WriteLine(a);
}