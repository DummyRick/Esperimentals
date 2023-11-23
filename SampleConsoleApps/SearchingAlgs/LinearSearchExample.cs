namespace SampleConsoleApps.SearchingAlgs
{
    public static class LinearSearchExample
    {
        public static void Main()
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original array:");
            PrintArray(array);

            int target = 22;
            int result = LinearSearch(array, target);

            if (result != -1)
            {
                Console.WriteLine($"\n{target} found at index {result}");
            }
            else
            {
                Console.WriteLine($"\n{target} not found in the array");
            }
        }


        // A linear search runs in at worst linear time and makes at most n comparisons, where n is the length of the list.
        // O(n)
        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                // If the target is found, return the index
                if (arr[i] == target)
                {
                    return i;
                }
            }

            // If the target is not present in the array
            return -1;
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
