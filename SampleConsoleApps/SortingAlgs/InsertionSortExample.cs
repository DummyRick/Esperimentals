namespace SampleConsoleApps.Algs
{
    public static class InsertionSortExample
    {
        public static void Main()
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original array:");
            PrintArray(array);

            SelectionSort(array);

            Console.WriteLine("\nSorted array:");
            PrintArray(array);
        }

        /// <summary>
        /// cicla dalla posizione 0 alla posizione N
        /// Cerca il minimo tra i rimanenti e swappa la posizione.
        /// Complessità: 
        /// </summary>
        /// <param name="arr"></param>
        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in the unsorted part of the array
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with the first element
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

}
