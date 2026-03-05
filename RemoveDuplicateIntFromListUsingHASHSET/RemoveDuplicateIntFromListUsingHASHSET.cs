using System;
using System.Collections.Generic;

class RemoveDuplicateIntFromListUsingHASHSET
{
    static void Main()
    {
        List<int> ints = new List<int> { 1,2, 3, 2, 4, 1, 5 };
        HashSet<int> uniqueNumbers = new HashSet<int>();

        foreach (int number in ints)
        {
            uniqueNumbers.Add(number);
        }

        Console.WriteLine("Unique integers in the list:");
        foreach(int num in uniqueNumbers)
        {
            Console.WriteLine(num);
        }
        Console.ReadLine();
    }
}