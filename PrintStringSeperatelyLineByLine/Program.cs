using System;

namespace PrintStringLineByLine
{
    public class PrintString
    {
        static void Main()
        {
            string str = "I am learning C# programming language";
            string[] strArr = str.Split(" ");
            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine(strArr[i]);
            }
            Console.ReadLine();
        }
    }
}