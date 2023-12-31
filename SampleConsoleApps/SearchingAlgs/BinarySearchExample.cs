﻿namespace SampleConsoleApps.SearchingAlgs
{
    public static class BinarySearchExample
    {
        public static void Main()
        {
            int[] array = { 11, 22, 25, 34, 64, 90 };

            Console.WriteLine("Original array:");
            PrintArray(array);

            int target = 34;
            int result = BinarySearch(array, target);

            if (result != -1)
            {
                Console.WriteLine($"\n{target} found at index {result}");
            }
            else
            {
                Console.WriteLine($"\n{target} not found in the array");
            }
        }


        /// <summary>
        /// Si divide sempre l'array a metà andando a prendere la media del valore fino a trovarlo.
        /// Binary search runs in logarithmic time in the worst case, making O(log n) comparisons, where n is the number of elements in the array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if target is present at the mid position
                if (arr[mid] == target)
                {
                    return mid;
                }

                // If target is greater, ignore the left half
                if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                // If target is smaller, ignore the right half
                else
                {
                    right = mid - 1;
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
