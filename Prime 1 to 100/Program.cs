using System;

namespace Prime_1_to_100
{
    class Program
    {
       public static void Main(string[] args)
        {
            bool IsPrime = true;

            int i, j;

            Console.WriteLine("Prime numbers are:-");
            for (i = 2; i <= 100; i++)
            {
                for (j = 2; j <= 100; j++)
                {
                    if(i!=j && i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    Console.Write("\t" + i);
                }
                IsPrime = true;
            }
            Console.ReadLine();
        }
    }
}
