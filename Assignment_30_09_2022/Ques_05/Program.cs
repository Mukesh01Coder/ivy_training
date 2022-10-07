using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to calculate the multiplication table and the factorial of the given
//number. Get the number as an input from the user. 
namespace Ques_05
{
    internal class Program
    {
        public static int fac(int n)
        {
            int ans = 1;
            for(int i = n; i > 0; i--)
            {
                ans = ans * i;
            }
            return ans;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number to calculate factorial and Table: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Print The Multiplication Table: ");
            for (int i = 1; i <= 10; ++i)
            {
                Console.WriteLine($"{i}*{n} : {i * n}");
            }

            int res = fac(n);
            Console.WriteLine("Print Factorial of given Number: ");
            Console.WriteLine(res);

        }
    }
}
