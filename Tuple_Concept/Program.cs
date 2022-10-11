using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple_Concept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuple<string> t = new Tuple<string>("mukesh");

            var t1 = Tuple.Create("gita", 345, 'a', 45, "sadfhiuds", 'b', 1001, Tuple.Create(2, "hello", 4, 5, 6, 'a', 7, Tuple.Create("ad", 34, 56.0)));

          //  Console.WriteLine($"{t1.Item1} , {t1.Item2} , {t1.Item3},{t1.Item4},{t1.Item5},{t1.Item6},{t1.Item7},{t1.Rest}");

           
           Console.WriteLine(t1);
            Console.WriteLine(t1.Rest.Item1.Rest.Item1.Item2);
            
        }
    }
}
