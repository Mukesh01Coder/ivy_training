using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a delegate which will take one integer argument. And write functions for 
    factorial, Fibonacci, Factors of number, Table of Number and call the functions
    through delegate.*/

namespace Lambda_Ecpression
{
    public delegate void ele(int a);

    public class Number
    {
        public void fib(int a)
        {
            int[] arr = new int[a];

            arr[0] = 0;
            arr[1] = 1; 

            for(int i = 2; i < a; i++)
            {
                arr[i] = arr[i - 1] + arr[i-2];
            }
            Console.WriteLine("Fibonacci series: ");
            for (int i = 0; i < a; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
        public void fac(int a)
        {
            int res = 1;

           for(int i = a; i > 0; i--)
            {
                res = res * i;
            }

           Console.WriteLine($"Factorial of {a}:{res}");

        }
        public void fact(int a)
        {
            int i = 0;

            Console.WriteLine($"Factors of {a} :");
            for (i = 1; i <= a; i++)
            {
                if (a % i == 0)
               
                    Console.Write(i + " ");
               
            }
            Console.WriteLine();
        }
        public void table(int a)
        {
            int[] arr2 = new int[11];

            
            for(int i = 1; i <= 10; i++)
            {
                arr2[i] = a * i;
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Arr2[{i}]*{i}: {arr2[i]}");
            }
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
             

            Number  item = new Number();

            ele obj = new ele(item.fib);
            Console.WriteLine("Enter the Number for Fibonacci series: ");
            obj(Convert.ToInt32(Console.ReadLine()));

            obj = item.fac;
            Console.WriteLine("Enter the number for factorial: ");
            obj(Convert.ToInt32(Console.ReadLine()));

            obj = item.fact;
            Console.WriteLine("Enter The Number for Find Factor: ");
            obj(Convert.ToInt32(Console.ReadLine()));

            obj = item.table;
            Console.WriteLine("Enter The Number for Table: ");
            obj(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
