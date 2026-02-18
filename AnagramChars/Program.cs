using System;

namespace AnagramChars
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(IsAnagram("listen", "silent"));  // true
            Console.WriteLine(IsAnagram("hello", "world"));    // false
            Console.ReadLine();
        }

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();

            Array.Sort(sArray);
            Array.Sort(tArray);

            return new string(sArray) == new string(tArray);
        }
    }
}
