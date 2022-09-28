using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_28_09_2022
{
    public delegate int sum(int n1);//q1,q4

    public delegate int find(int n2, int n3);//q2
    public delegate void swap(int n4, int n5);//q3

    public delegate void Sort(int[] arr1);//q6
    internal class Program
    {
        static void Main(string[] args)
        {
            // q1: Write a statement lambda to calculate sum of 1 to n number.
             Console.WriteLine("Enter n1 :");

             int n1 = Convert.ToInt32(Console.ReadLine());

             sum s = (p1) =>
             {
                 int ans = 0;
                 for (int i = 1; i <= n1; i++)
                 {
                     ans += i;
                 }
                 return ans;
             };
             int res = s.Invoke(n1);
             Console.WriteLine("Sum of n1 Num :" + res);

            /*q2 Write an expression lambda to find greater between two numbers.*/
            Console.WriteLine("Enter n2 :");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter n3 :");
            int n3 = Convert.ToInt32(Console.ReadLine());

            find grt = (p2, p3) => (n2 > n3 ? n2 : n3);

            int res1 = grt.Invoke(n2, n3);

            Console.WriteLine("Greater num:" + res1);

            // q3: Write an lambda expression to swap given two numbers.

            swap sp = (p4, p5) =>
            {
                 n2 = n2 + n3;

                 n3 = n2 - n3;
                 n2 = n2 - n3;

               

                Console.WriteLine($"Swap two numbers: n2 :{n2}  n3:{n3}");
            };
            sp.Invoke(n2, n3);


            // q4: Write an anonymous function to check given number is prime or not.
            Console.WriteLine("Enter n4 :");
            int n4 = Convert.ToInt32(Console.ReadLine());


            s =(p6) =>
            {
                for (int i = 2; i < n4; i++)
                {
                    if (n4 % i == 0) return 0;


                }
                return 1;
            };
            int flag = s(n4);

            if (flag == 1) Console.WriteLine($"{n4} is Prime Number");
            else Console.WriteLine($"{n4} is not Prime Number");
          

            //q6 :Write an lambda expression to sort given array.*/
            Console.WriteLine("Enter Size of Array:");
            int n5 = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n5];


            for (int i = 0; i < arr.Length; i++)
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





 
     
      
           

           

        
        
               

         
   