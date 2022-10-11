using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_PrimeNum
{
    internal class Program
    {
        public delegate bool prime(int x);
        public delegate void prime_num(int n);
        static void Main(string[] args)
        {
            //q5 : write a C# program to print prime number upto n using lambda expression;

            Console.WriteLine("Enter n Number :");

            int n = Convert.ToInt32(Console.ReadLine());

            prime isPrime = (p1) =>
            {
                if (p1 <= 1)
                    return false;

                for (int i = 2; i < p1; i++)
                    if (p1 % i == 0)
                        return false;

                return true;

            };

            prime_num pr = (prt) =>
            {
                for (int i = 2; i <= n; i++)
                {
                    if (isPrime(i))
                        Console.Write(i + " ");
                }
                Console.WriteLine();
            };
            pr(n);
        }
    }
}
