using System;

int totalCount = 0;
int totalSum = 0;
int fiveCount = 0;

while (true)
{
    int currentGrade = Grades.Read();
    if (currentGrade == Grades.Stop)
    {
        break;
    }

    if (Grades.IsValid(currentGrade))
    {
        totalCount++;
        totalSum += currentGrade;

        if (currentGrade == Grades.Max)
        {
            fiveCount++;
        }
    }
    else
    {
        Console.WriteLine($"Ошибка: введите оценку от {Grades.Min} до {Grades.Max} (или {Grades.Stop} для выхода).");
    }
}

Grades.PrintStats(totalCount, totalSum, fiveCount);

static class Grades
{
    public const int Min = 2;
    public const int Max = 5;
    public const int Stop = 0;

    public static int Read()
    {
        string? line = Console.ReadLine();
        return int.TryParse(line, out int parsedValue) ? parsedValue : -1;
    }

    public static bool IsValid(int g) => g >= Min && g <= Max;

    public static void PrintStats(int count, int sum, int fives)
    {
        if (count <= 0)
        {
            Console.WriteLine("Оценок нет");
            return;
        }

        double avg = (double)sum / count;
        Console.WriteLine($"Количество: {count}, Средний балл: {avg:F2}, Пятёрок: {fives}");
    }
}