using System;

namespace lab3
{
    internal class Helper
    {
        private static Random random = new Random();

        public static int[] GenerateIntArrayWithRandValues(int sizeOfArray)
        {
            int[] resultArray = new int[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
            {
                resultArray[i] = random.Next(101);
            }
            return resultArray;
        }

        public static void PrintIntArrayToConsole(int[] arrayToPrint)
        {
            for (int i = 0; i < arrayToPrint.Length; i++)
            {
                Console.Write(arrayToPrint[i] + "\t");
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        public static int LinearSearch(int[] haystack, int needle, out int numOfComparison)
        {
            numOfComparison = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                numOfComparison++;

                if (haystack[i] == needle)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int BubbleSort(int[] arr)
        {
            int swapCount = 0;
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i - 1] > arr[i])
                    {
                        int temp = arr[i - 1];
                        arr[i - 1] = arr[i];
                        arr[i] = temp;
                        swapped = true;
                        swapCount++;
                    }
                }
            } while (swapped);

            return swapCount;
        }

        public static int BinarySearch(int[] haystack, int needle, out int numOfComparison)
        {
            numOfComparison = 0;
            int low = 0;
            int high = haystack.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                numOfComparison++;

                if (haystack[mid] == needle)
                {
                    return mid;
                }
                else if (haystack[mid] < needle)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }
    }
}
