using System;

namespace PrimeNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(" please Enter the first number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the secound number:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("The prime numbers from {0} to {1} are:", n1, n2);
            for (int i = n1; i <= n2; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static bool IsPrime(int n)
        {
            
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}

