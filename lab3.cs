using lab3;
using System;

namespace Lab3
{
    class Lab3
    {
        static void Main()
        {

            int[] originalArray = Helper.GenerateIntArrayWithRandValues(100);


            Console.WriteLine("Original Array:");
            Helper.PrintIntArrayToConsole(originalArray);

            int[] newArray = new int[originalArray.Length];
            originalArray.CopyTo(newArray, 0);


            int swapCount = Helper.BubbleSort(newArray);


            Console.WriteLine($"Number of Swaps performed to sort the array: {swapCount}");


            Console.WriteLine("Sorted Array:");
            Helper.PrintIntArrayToConsole(newArray);

            do
            {

                Console.Write("Enter an integer: ");
                if (int.TryParse(Console.ReadLine(), out int userValue))
                {

                    int linearSearchIndex = Helper.LinearSearch(originalArray, userValue, out int linearSearchComparisons);

                    if (linearSearchIndex != -1)
                    {
                        Console.WriteLine($"Linear Search: Value found at index {linearSearchIndex}. Comparisons: {linearSearchComparisons}");
                    }
                    else
                    {
                        Console.WriteLine($"Linear Search: Value not found. Comparisons: {linearSearchComparisons}");
                    }


                    int binarySearchIndex = Helper.BinarySearch(newArray, userValue, out int binarySearchComparisons);

                    if (binarySearchIndex != -1)
                    {
                        Console.WriteLine($"Binary Search: Value found at index {binarySearchIndex}. Comparisons: {binarySearchComparisons}");
                    }
                    else
                    {
                        Console.WriteLine($"Binary Search: Value not found. Comparisons: {binarySearchComparisons}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }


                Console.Write("Do you want to search another integer? (Y/N): ");
            } while (Console.ReadLine()?.Trim().ToUpper() == "Y");


            Console.WriteLine("Program terminated.");
        }
    }
}