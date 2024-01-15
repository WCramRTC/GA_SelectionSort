# Guided Assignment - Implementing Selection Sort in C#

## Introduction
Selection Sort is a fundamental sorting algorithm known for its simplicity and ease of implementation. It works by repeatedly selecting the minimum element from the unsorted section of an array and placing it at the beginning. This process is repeated until the entire array is sorted.

### Pseudocode

```pseudocode
procedure selectionSort(arr: List of Comparable)
    // Get the length of the input array
    arrayLength = length(arr)
    
    // Iterate through the array
    for currentIndex from 0 to arrayLength - 1
        // Assume the current index as the minimum
        minIndex = currentIndex

        // Find the minimum element in the remaining unsorted array
        for unsortedIndex from currentIndex + 1 to arrayLength - 1
            if arr[unsortedIndex] < arr[minIndex]
                minIndex = unsortedIndex
        end for

        // Swap the found minimum element with the element at the current index
        swap arr[currentIndex] and arr[minIndex]
    end for
end procedure
```

---

## Detailed Requirements

**Project Setup (10 Points):**

- Create a new console application in your IDE.
- Name the project `GA_SelectionSort_YourName` (replace "YourName" with your actual name).
- Add a comment on the main page of your program with your name.

**Understanding of Selection Sort Algorithm (15 Points):**

- Write pseudo-code explaining the Selection Sort algorithm.
- Describe the process of selecting the minimum element and moving it to the beginning of the array.
- Explain the significance of finding the minimum element in each iteration.

**Implementation of Selection Sort (15 Points):**

- Implement the Selection Sort algorithm in C#.
- Ensure your code adheres to the provided algorithm.
- Include clear comments explaining each step of the code.

**Explanation of Algorithm Logic (15 Points):**

- Provide comments detailing:
    - The purpose of the outer loop and the inner loop.
    - The process of finding the minimum element.
    - How the algorithm maintains the sorted and unsorted portions of the array.

**Implementing Efficient Sorting Technique (15 Points):**

- Implement conditions to optimize sorting efficiency using Selection Sort.
- Use comments to explain how these conditions improve sorting efficiency.
- Discuss the impact of these conditions in reducing unnecessary operations.

**Optimizing the Sorting Process (15 Points):**

- Enhance the sorting to minimize operations once the minimum element is found.
- Explain how this optimization benefits overall performance.
- Discuss the importance of optimization in sorting algorithms.

**Code Testing and Output Accuracy (10 Points):**

- Create test cases in the `Main` method to demonstrate Selection Sort.
- Test with arrays of various sizes and types.
- Ensure the output is correctly sorted.

**Submission (5 Points):**

- Upload the complete project to GitHub.
- Make the repository public and include all necessary files.
- Provide the GitHub repository link in your Canvas submission.

**Total (100 Points):**

- Each section is essential.
- Points are allocated based on the detailed requirements accurately met.

Please follow these requirements closely to meet all the criteria outlined in the rubric for your assignment.

---

## Step By Step Instructions

***Final Code (We will be building step by step)***
```csharp
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
```

---
## Step 1: Initialization
```csharp
static void SelectionSortArray(int[] arr)
{
	// Step 1 - Initialization
	int arrayLength = arr.Length;
}
```
In this step, we obtain the length of the input array `arr`, which helps us determine the number of elements in the array.

---
## Step 2: Outer Loop
```csharp
static void SelectionSortArray(int[] arr)
{
	int arrayLength = arr.Length;

	// Step 2 - Outer Loop
	for (int currentIndex = 0; currentIndex < arrayLength - 1; currentIndex++)
	{
	    // ...
	}
}
```
We start an outer loop that iterates through the array from the first element (index 0) to the second-to-last element (index `arrayLength - 2`). This loop will help us select each element one by one for proper placement.

---
## Step 3: Assumption of Minimum
```csharp
static void SelectionSortArray(int[] arr)
{
	int arrayLength = arr.Length;

	for (int currentIndex = 0; currentIndex < arrayLength - 1; currentIndex++)
	{
		// Step 3 - Assumption of Minimum
	    int minIndex = currentIndex;
	}
}
```
We initialize `minIndex` with the current index (`currentIndex`) to assume that the current element is the minimum within the unsorted portion of the array. This is a temporary minimum value until we find a smaller value.

---
## Step 4: Inner Loop
```csharp
static void SelectionSortArray(int[] arr)
{
	int arrayLength = arr.Length;

	for (int currentIndex = 0; currentIndex < arrayLength - 1; currentIndex++)
	{
	
	    int minIndex = currentIndex;
		// Step 4 - Inner Loop
		for (int unsortedIndex = currentIndex + 1; unsortedIndex < arrayLength; unsortedIndex++)
		{
		    // ...
		}
	}
}
```
Within the outer loop, we start an inner loop that iterates through the remaining unsorted portion of the array. We begin from the element next to the current element (index `currentIndex + 1`) and continue to the last element (index `arrayLength - 1`). This inner loop helps us find the minimum element within the unsorted part.

---
## Step 5: Comparison
```csharp
static void SelectionSortArray(int[] arr)
{
	int arrayLength = arr.Length;

	for (int currentIndex = 0; currentIndex < arrayLength - 1; currentIndex++)
	{
	
	    int minIndex = currentIndex;

		for (int unsortedIndex = currentIndex + 1; unsortedIndex < arrayLength; unsortedIndex++)
		{
			// Step 5 - Comparison
		    if (arr[unsortedIndex] < arr[minIndex])
			{
			    minIndex = unsortedIndex;
			}
		}
	}
}
```
Inside the inner loop, we compare the element at the current `unsortedIndex` with the element at the `minIndex` (the assumed minimum). If the element at `unsortedIndex` is smaller than the assumed minimum, we update `minIndex` to point to the `unsortedIndex`. This step ensures we find the smallest element within the remaining unsorted portion of the array.

---
## Step 6: Swap
```csharp
static void SelectionSortArray(int[] arr)
{
	int arrayLength = arr.Length;

	for (int currentIndex = 0; currentIndex < arrayLength - 1; currentIndex++)
	{
	
	    int minIndex = currentIndex;

		for (int unsortedIndex = currentIndex + 1; unsortedIndex < arrayLength; unsortedIndex++)
		{
			// Step 5 - Comparison
		    if (arr[unsortedIndex] < arr[minIndex])
			{
			    minIndex = unsortedIndex;
			}
		}

		// Step 6 - Swap
		int temp = arr[minIndex];
		arr[minIndex] = arr[currentIndex];
		arr[currentIndex] = temp;
	}
}
```
After completing the inner loop, we've found the actual minimum element within the unsorted part of the array. We then swap this minimum element with the element at the `currentIndex`. This step ensures that the smallest element is correctly placed at its sorted position at the beginning of the array.

---
## Step 7: Display
```csharp
 static void SelectionSortArray(int[] arr)
 {
     int arrayLength = arr.Length;

     for (int currentIndex = 0; currentIndex < arrayLength - 1; currentIndex++)
     {
         int minIndex = currentIndex;

         for (int unsortedIndex = currentIndex + 1; unsortedIndex < arrayLength; unsortedIndex++)
         {
             if (arr[unsortedIndex] < arr[minIndex])
             {
                 minIndex = unsortedIndex;
             }
         }

         int temp = arr[minIndex];
         arr[minIndex] = arr[currentIndex];
         arr[currentIndex] = temp;

         // Step 7 - For this exercise : Display what is happening
         Console.Write($"Iteration {currentIndex + 1}: ");
         PrintArray(arr);
     }
 }
```
Finally, after each iteration of the outer loop, we display the current state of the array to visualize how the elements are being sorted. This step helps us track the progress of the sorting process.

These steps work together to perform selection sort, where the algorithm repeatedly selects the minimum element from the unsorted portion of the array and moves it to the beginning of the sorted portion. This process continues until the entire array is sorted.

---
## Full Code to Run

***Run our code and test out the result***
```csharp
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
```


***Expected Output***
```console
Original Array:
64 25 12 22 11 36 8 42 5 38 

Iteration 1: 5 25 12 22 11 36 8 42 64 38 
Iteration 2: 5 8 12 22 11 36 25 42 64 38 
Iteration 3: 5 8 11 22 12 36 25 42 64 38 
Iteration 4: 5 8 11 12 22 36 25 42 64 38 
Iteration 5: 5 8 11 12 22 25 36 42 64 38 
Iteration 6: 5 8 11 12 22 25 36 42 64 38 
Iteration 7: 5 8 11 12 22 25 36 38 64 42 
Iteration 8: 5 8 11 12 22 25 36 38 42 64 

Sorted Array:
5 8 11 12 22 25 36 38 42 64 

```

---
## Rubric

| Criteria                                 | Description                                                                                                         | Points |
|------------------------------------------|---------------------------------------------------------------------------------------------------------------------|--------|
| **Project Setup**                        | Proper creation of a new console application named GA_SelectionSort_YourName, with the student's name commented on the main page. | 10     |
| **Understanding of Selection Sort Algorithm** | Clear explanation and pseudo-code of Selection Sort.                                                                | 15     |
| **Implementation of Selection Sort**     | Correct implementation of Selection Sort in C#.                                                                     | 15     |
| **Explanation of Algorithm Logic**       | Detailed comments explaining the logic of the algorithm.                                                            | 15     |
| **Implementing Efficient Sorting Technique** | Correct implementation and explanation of efficient sorting techniques.                                              | 15     |
| **Optimizing the Sorting Process**       | Implementation and explanation of optimization techniques.                                                          | 15     |
| **Code Testing and Output Accuracy**     | Successful testing and demonstration of accurate sorting.                                                           | 10     |
| **Submission**                           | Successful upload to GitHub with the correct link provided.                                                         | 5      |
| **Total**                                |                                                                                                                     | 100    |

