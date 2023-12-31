﻿namespace SampleConsoleApps.Algs;

public static class BubbleSortExample
{
    public static void Main()
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Original array:");
        PrintArray(array);

        BubbleSort(array);

        Console.WriteLine("\nSorted array:");
        PrintArray(array);
    }

    /// <summary>
    /// Si swappa l'elemento fino a ordinarlo completamente.
    /// This simple algorithm performs poorly in real world use and is used primarily as an educational tool.
    /// O(n2) = una merda
    /// </summary>
    /// <param name="arr"></param>
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++) // Da capire questa condizione.
            {
                // Swap if the element found is greater than the next element
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
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
