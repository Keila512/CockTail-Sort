using System;
using System.Collections.Generic;

class CocktailSort
{
    static void Main(string[] args)
    {
        List<int> arr = new List<int> { 1, 2, 9, 0, 7, 9 };
        cocktailSort(arr);
        foreach (var x in arr)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
        Console.ReadKey();
    }

    static void cocktailSort(List<int> arr)
    {
        int n = arr.Count;
        bool swapped = true;
        int start = 0;
        int end = n - 1;
        while (swapped)
        {
            // Move from left to right
            swapped = false;
            for (int i = start; i < end; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    Swap(arr, i, i + 1);
                    swapped = true;
                }
            }
            if (!swapped)
            {
                break;
            }
            end--;
            // Move from right to left
            swapped = false;
            for (int i = end - 1; i >= start; i--)
            {
                if (arr[i] > arr[i + 1])
                {
                    Swap(arr, i, i + 1);
                    swapped = true;
                }
            }
            start++;
        }
    }

    static void Swap(List<int> arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}