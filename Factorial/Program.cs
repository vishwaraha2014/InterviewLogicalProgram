using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            //Console.Write($"Factorial of {number}  is: {factorial}");

            int ret = Recortion(number);
            Console.Write($"Recortion of {number}  is: {ret}");
            Console.ReadLine();
        }

        public static int Recortion(int n)
        {
            if (n == 1)
            {
                return n;
            }
            return n * Recortion(n - 1);
        }
    }
}
