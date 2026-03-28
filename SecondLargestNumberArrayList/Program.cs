using System;

public class Program
{
    static void Main()
    {
        int[] intArr = { 1, 2, 3, 4 };

        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        for (int i = 0; i < intArr.Length; i++)
        {
            if (intArr[i] > largest)
            {
                secondLargest = largest;
                largest = intArr[i];
            }
            //else if (intArr[i] > secondLargest && intArr[i] != largest)
            //{
            //    secondLargest = intArr[i];
            //}
        }

        Console.WriteLine("Second Largest Number: " + secondLargest);
        Console.ReadLine();
    }
}