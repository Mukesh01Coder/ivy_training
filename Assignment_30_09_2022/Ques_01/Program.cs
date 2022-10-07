using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n =  Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for(int i= 0; i < n; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());

                arr[i] = x; 
            }
            int mn = 1000000;int mx = -1000000000;
          for(int i = 0; i < n; i++)
            {
               mn = Math.Min(mn, arr[i]);
               mx = Math.Max(mx, arr[i]);
            }


            Console.WriteLine("Minimum Value Of Array is : "+ mn);

            Console.WriteLine("Maximum Value Of Array is : " + mx);
        }
    }
}
