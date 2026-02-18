using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n, m, i = 0, flag = 0;

            Console.Write("Enter Number:");
            n = int.Parse(Console.ReadLine());

            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.Write("number is prime");
            }
            Console.ReadLine();
        }
    }
}
