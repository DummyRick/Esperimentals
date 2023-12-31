﻿namespace SampleConsoleApps.Algs
{
    public static class SelectionSortExample
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
        /// Sempre un algorirmo di merda
        /// O (n2 )
        /// In computer science, selection sort is an in-place comparison sorting algorithm. 
        /// It has an O(n2) time complexity, which makes it inefficient on large lists, and generally performs worse than the similar insertion sort.
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
