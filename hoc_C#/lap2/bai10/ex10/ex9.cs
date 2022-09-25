using System;
using System.Collections;
namespace Program
{
    class PrimeNumber
    {
        static int isPrimeNumber(int n)
        {
            if (n < 2)
            {
                return 0;
            }
            int i;
            int squareRoot = (int)Math.Sqrt(n);
            for (i = 2; i <= squareRoot; i++)
            {
                if (n % i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }

        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Enter n = ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 11);
            
            Console.Write("{0} display all prime numbers from 0: \n", n);
            int count = 0;
            int i = 2;
            while (count < n)
            {
                if (isPrimeNumber(i) == 1)
                {
                    Console.Write("{0} ", i);
                    count++;
                }
                i++;
            }
        }
    }
}