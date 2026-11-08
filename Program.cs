namespace ArrayAlgos
{
    public static class ArrayAlgos
    {
        /// <summary>
        /// </summary>
        public static bool IsSorted(int[] a)
        {
            if (a == null || a.Length <= 1)
            {
                return true;
            }

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// </summary>
        public static int BubbleSort(int[] a)
        {
            if (a == null || a.Length <= 1)
            {
                return 0;
            }

            int comparisons = 0;
            int n = a.Length;

            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < n - 1 - i; j++)
                {
                    comparisons++;
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }

            return comparisons;
        }

        /// <summary>
        /// </summary>
        private static int LowerBound(int[] a, int x)
        {
            int lo = 0;
            int hi =