namespace ArrayAlgos
{
    internal class Program
    {
        private static string ArrayToString(int[] arr)
        {
            return "[" + string.Join(", ", arr) + "]";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== ТЕСТИРОВАНИЕ BUBBLESORT ===");
            int[][] testCases = new int[][]
            {
                new int[] { },
                new int[] { 5 },
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 5, 4, 3, 2, 1 },
                new int[] { 3, 1, 3, 2, 3 }
            };

            foreach (var original in testCases)
            {
                int[] copy = (int[])original.Clone();
                Console.WriteLine($"До:      {ArrayToString(original)}");
                
                int comparisons = ArrayAlgos.BubbleSort(copy);
                bool sorted = ArrayAlgos.IsSorted(copy);
                
                Console.WriteLine($"После:   {ArrayToString(copy)}");
                Console.WriteLine($"IsSorted: {sorted}, Сравнений: {comparisons}\n");
            }

            int[] thousandSorted = new int[1000];
            for (int i = 0; i < thousandSorted.Length; i++)
            {
                thousandSorted[i] = i;
            }
            int thousandComparisons = ArrayAlgos.BubbleSort(thousandSorted);
            Console.WriteLine($"Массив из 1000 элементов: сравнений = {thousandComparisons} (ожидается: 999)\n");

            Console.WriteLine("=== ТЕСТИРОВАНИЕ COUNTOCCURRENCES ===");
            int[] sortedArr = { 1, 2, 2, 2, 5, 7 };
            int[] queryValues = { 2, 1, 7, 3, 9 };

            Console.WriteLine($"Исходный массив: {ArrayToString(sortedArr)}");
            foreach (int x in queryValues)
            {
                int count = ArrayAlgos.CountOccurrences(sortedArr, x);
                Console.WriteLine($"x = {x}: вхождений = {count}");
            }
        }
    }
}