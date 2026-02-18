using System;

namespace RemoveDuplicateChars
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string result = RemoveDuplicateChars(input);
            Console.WriteLine(result);  // Output
            Console.ReadLine();
        }
        public static string RemoveDuplicateChars(string str)
        {
            char[] chars = str.ToCharArray();
            string result = "";
            foreach (char c in chars)
            {
                if (!result.Contains(c))
                {
                    result += c;
                }
            }
            return result;
        }
    }
}