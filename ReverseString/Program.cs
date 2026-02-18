using System;

namespace ReverseString
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter string:");
            string OrgString = Console.ReadLine();
            char[] charArrStr = OrgString.ToCharArray();
            string ReverseStr = string.Empty;

            for (int i = charArrStr.Length - 1; i > -1; i--)
            {
                ReverseStr += charArrStr[i];
            }

            Console.Write($"Reverse string of '{OrgString}' is : {ReverseStr}");
            Console.ReadLine();
        }
    }
}
