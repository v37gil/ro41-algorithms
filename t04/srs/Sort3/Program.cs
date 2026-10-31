using System;

RunCase(3, 1, 2);
RunCase(1, 2, 3);
RunCase(3, 2, 1);
RunCase(2, 2, 1);
RunCase(5, 5, 5);

static void RunCase(int x, int y, int z)
{
    string before = $"{x} {y} {z}";
    Order.Sort3(ref x, ref y, ref z);
    Console.WriteLine($"{before} -> {x} {y} {z}");
}

static class Order
{
    public static void Swap(ref int x, ref int y)
    {
        (x, y) = (y, x);
    }

    public static void Sort3(ref int a, ref int b, ref int c)
    {
        if (a > c)
        {
            Swap(ref a, ref c);
        }
        if (a > b)
        {
            Swap(ref a, ref b);
        }
        if (b > c)
        {
            Swap(ref b, ref c);
        }
    }
}