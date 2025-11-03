public class Program
{
    static void Main(string[] args)
    {
        int[] favoriteNums = { 13, 11, 10, 30, 23 };
        Console.WriteLine("Original Array: ");
        foreach (int num in favoriteNums)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");

        Array.Sort(favoriteNums);
        Console.WriteLine("After sorting in ascending order:");
        foreach (int num in favoriteNums)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");

        Array.Sort(favoriteNums);
        Console.WriteLine("Array after sorting:");
        foreach (int num in favoriteNums)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");

        // 3. Reverse the sorted array
        Array.Reverse(favoriteNums);
        Console.WriteLine("Array after reversing:");
        foreach (int num in favoriteNums)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");

        // 4. Print each element using a for loop
        Console.WriteLine("Printing each element with for loop:");
        for (int i = 0; i < favoriteNums.Length; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + favoriteNums[i]);
        }

        // 5. Find the position of a specific number (e.g., 13)
        int searchNumber = 13;
        int index = Array.IndexOf(favoriteNums, searchNumber);
        if (index >= 0)
        {
            Console.WriteLine("\nThe number " + searchNumber + " is at index: " + index);
        }
        else
        {
            Console.WriteLine("\nThe number " + searchNumber + " was not found in the array.");
        }
    }
}