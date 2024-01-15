namespace GA_SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11, 36, 8, 42, 5, 38 };

            Console.WriteLine("Original Array:");
            PrintArray(arr);

            SelectionSortArray(arr);

            Console.WriteLine("\nSorted Array:");
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void SelectionSortArray(int[] arr)
        {
            int arrayLength = arr.Length;

            for (int currentIndex = 0; currentIndex < arrayLength - 1; currentIndex++)
            {
                int minIndex = currentIndex;

                // Find the minimum element in the remaining unsorted portion of the array
                for (int unsortedIndex = currentIndex + 1; unsortedIndex < arrayLength; unsortedIndex++)
                {
                    if (arr[unsortedIndex] < arr[minIndex])
                    {
                        minIndex = unsortedIndex;
                    }
                }

                // Swap the found minimum element with the element at currentIndex
                int temp = arr[minIndex];
                arr[minIndex] = arr[currentIndex];
                arr[currentIndex] = temp;

                // Display the current state of the array after each iteration
                Console.Write($"Iteration {currentIndex + 1}: ");
                PrintArray(arr);
            }
        }
    }
}
