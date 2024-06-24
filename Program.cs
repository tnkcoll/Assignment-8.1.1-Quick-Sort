namespace Assignment_8._1._1_Quick_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 10, 7, 8, 9, 1, 5 };
            int n = ints.Length;

            Console.WriteLine("Unsorted Array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{ints[i]} ");
            }
            Console.WriteLine();

            QuickSort(ints, 0, n - 1);

            Console.WriteLine("Sorted Array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{ints[i]} ");
            }
        }

        static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return i + 1;
        }

        static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int p = partition(arr, low, high);

                QuickSort(arr, low, p - 1);
                QuickSort(arr, p + 1, high);
            }
        }
    }
}
