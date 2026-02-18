using System;

class MainClass
{

    internal static bool PalindromeTwo(string str)
    {

        // code goes here  
        bool flag = false;
        for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
        {
            if (str[i] != str[j])
            {
                flag = false;
                break;
            }
            else
            {
                flag = true;
            }
        }
        return flag;
    }

    // keep this function call here
    static void Main()
    {

        Console.Write("Enter string :");
        string input = Console.ReadLine();
        bool output = PalindromeTwo(input);
        Console.WriteLine("Palindrome : " + output);
        Console.ReadLine();
    }

}