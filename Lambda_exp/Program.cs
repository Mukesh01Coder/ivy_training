using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// q1: Write a statement lambda to calculate sum of 1 to n number.

namespace Lambda_exp
{
    internal class Program
    {
        public delegate int cal(int n);//q1,q4

        public delegate int find(int n1,int n2);//q2
        public delegate void swap(int n1, int n2);//q3

        public delegate void Sort(int[] arr1);//q6
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num :");

            int n =Convert.ToInt32( Console.ReadLine());
            
            cal res = (p) =>
            {
                int ans = 0;
                for (int i = 1; i <= n; i++)
                {
                    ans += i;
                }
                return ans;
            };

            int result = res.Invoke(n);
            Console.WriteLine("Sum of n Num :"+result);

            /*q2 Write an expression lambda to find greater between two numbers.*/
            Console.WriteLine("Enter n1 :");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter n2 :");
            int n2 = Convert.ToInt32(Console.ReadLine());

            find k = (p1, p2) => (n1 > n2 ? n1 : n2);

            int result1 = k.Invoke(n1,n2);

            Console.WriteLine("Greater num:" + result1);
            // q3: Write an lambda expression to swap given two numbers.

            int res2 = n1 + n2;
           swap sp = (p3,p4) =>
           {
              
               n1 = n1 + n2;

               n2 = n1 - n2;
               n1 = n1 - n2;

               Console.WriteLine($"Swap both number:\n\n n1: {n1}  , n2: {n2}");

           };
            
            sp.Invoke(n1, n2);
            // q4: Write an anonymous function to check given number is prime or not.

            Console.WriteLine("Enter Num for Check Number is prime or not :");
            int n4 = Convert.ToInt32(Console.ReadLine());   
            res = (p5) =>
            {
                for (int i = 2; i < n4; i++)
                {
                    if (n4 % i == 0) return 0;
                    
            
                }
                return 1;
            };
          int flag =   res(n4);

            if (flag == 1) Console.WriteLine($"{n4} is Prime Number");
            else Console.WriteLine($"{n4} is not Prime Number");

            //q5 :Write an lambda expression to print all prime numbers up to n.

            //q6 :Write an lambda expression to sort given array.*/
            Console.WriteLine("Enter Size of Array:");
            int n5 = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n5];

           
            for(int i=0; i<arr.Length; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                arr[i] = x;
            }
            Sort srt = (int[] arr2) =>
            {
                Array.Sort(arr);

                Console.WriteLine("Print Sorted Array: ");
                foreach (int i in arr)
                    Console.Write(i + " ");

                Console.WriteLine();
            };

            srt.Invoke(arr);
        }
    }
}
