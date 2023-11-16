using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApps.Algs
{
    class MergeSortExample
    {
        static void Main()
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original array:");
            PrintArray(array);

            MergeSort(array, 0, array.Length - 1);

            Console.WriteLine("\nSorted array:");
            PrintArray(array);
        }

        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Find the middle point
                int middle = (left + right) / 2;

                // Recursively sort the first and second halves
                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);

                // Merge the sorted halves
                Merge(arr, left, middle, right);
            }
        }

        static void Merge(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            // Create temporary arrays
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            // Copy data to temporary arrays
            for (int i = 0; i < n1; ++i)
                leftArray[i] = arr[left + i];

            for (int j = 0; j < n2; ++j)
                rightArray[j] = arr[middle + 1 + j];

            // Merge the temporary arrays

            int iLeft = 0, iRight = 0, k = left;
            while (iLeft < n1 && iRight < n2)
            {
                if (leftArray[iLeft] <= rightArray[iRight])
                {
                    arr[k] = leftArray[iLeft];
                    iLeft++;
                }
                else
                {
                    arr[k] = rightArray[iRight];
                    iRight++;
                }
                k++;
            }

            // Copy the remaining elements of leftArray[], if there are any
            while (iLeft < n1)
            {
                arr[k] = leftArray[iLeft];
                iLeft++;
                k++;
            }

            // Copy the remaining elements of rightArray[], if there are any
            while (iRight < n2)
            {
                arr[k] = rightArray[iRight];
                iRight++;
                k++;
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
