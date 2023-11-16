using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApps.Algs
{
    public static class QuickSortExample
    {
        public static void Main()
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original array:");
            PrintArray(array);

            QuickSort(array, 0, array.Length - 1);

            Console.WriteLine("\nSorted array:");
            PrintArray(array);
        }

        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // Find pivot element such that elements smaller than pivot are on the left
                // and elements greater than pivot are on the right
                int pivotIndex = Partition(arr, low, high);

                // Recursively sort the sub-arrays
                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            // Choose the rightmost element as the pivot
            int pivot = arr[high];

            // Index of the smaller element
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                // If the current element is smaller than or equal to the pivot
                if (arr[j] <= pivot)
                {
                    // Swap arr[i] and arr[j]
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // Swap arr[i+1] and arr[high] (pivot)
            int tempPivot = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = tempPivot;

            // Return the index of the pivot element
            return i + 1;
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
