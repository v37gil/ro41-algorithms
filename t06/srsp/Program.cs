namespace ArrayOpsProject
{
    public static class ArrayOps
    {
        public static int Sum(int[] a)
        {
            int total = 0;
            for (int i = 0; i < a.Length; i++)
            {
                total += a[i];
            }
            return total;
        }

        public static int IndexOfMin(int[] a)
        {
            int minVal = a[0];
            int minIdx = 0;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < minVal)
                {
                    minVal = a[i];
                    minIdx = i;
                }
            }
            return minIdx;
        }

        public static int CountGreater(int[] a, int x)
        {
            int counter = 0;
            foreach (int item in a)
            {
                if (item > x)
                {
                    counter++;
                }
            }
            return counter;
        }

        public static void Reverse(int[] a)
        {
            int left = 0;
            int right = a.Length - 1;

            while (left < right)
            {
                int temp = a[left];
                a[left] = a[right];
                a[right] = temp;

                left++;
                right--;
            }
        }
    }

    class Program
    {
        static string FormatArray(int[] arr)
        {
            return "{" + string.Join(", ", arr) + "}";
        }

        static void RunTest(int[] sample)
        {
            Console.WriteLine($"Исходный массив: {FormatArray(sample)}");
            Console.WriteLine($"  Sum = {ArrayOps.Sum(sample)}");
            Console.WriteLine($"  IndexOfMin = {ArrayOps.IndexOfMin(sample)}");
            Console.WriteLine($"  CountGreater(x = 2) = {ArrayOps.CountGreater(sample, 2)}");

            ArrayOps.Reverse(sample);
            Console.WriteLine($"  После Reverse: {FormatArray(sample)}");
            Console.WriteLine();
        }

        static void Main()
        {
            int[][] testArrays = new int[][]
            {
                new int[] { 4, 1, 7, 3, 9 },
                new int[] { 5 },
                new int[] { -2, -7, -4 },
                new int[] { 2, 2, 2 }
            };

            foreach (int[] arr in testArrays)
            {
                RunTest(arr);
            }
        }
    }
}
