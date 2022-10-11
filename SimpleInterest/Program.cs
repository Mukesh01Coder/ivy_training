using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a anonymous function to find Simple interest.

namespace SimpleInterest
{
   public delegate double cal(double p, double r, double t);
    internal class Program
    {
        static void Main(string[] args)
        {
            cal ele = ( p, r,  t)=>
            {
                return (p*r*t)/100;
            };
            Console.WriteLine("Principle Amount: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Rate of Interest: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Time of Interest: ");
            double n3 = Convert.ToDouble(Console.ReadLine());

          double res =   ele.Invoke(n1,n2,n3);
            Console.WriteLine($"Simple Interest : {res}");
        }
    }
}
