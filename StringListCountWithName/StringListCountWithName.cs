using System;
using System.Collections.Generic;
using System.Text;

namespace StringListCountWithName
{
    public class StringListCountWithName
    {
       private static readonly List<string> stringList = new List<string>{"ram","shyam", "ram"};

        static void Main()
        {
            Dictionary<string, int> stringCount = new Dictionary<string, int>();
            foreach (var name in stringList)
            {
                if (stringCount.ContainsKey(name))
                {
                    stringCount[name]++;
                }
                else
                {
                    stringCount[name] = 1;
                }
            }

            foreach (var kvp in stringCount)
            {
                Console.WriteLine($"String: {kvp.Key}, Count: {kvp.Value}");
            }
            Console.ReadLine();
        }
    }
}
