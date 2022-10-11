using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2.AsynchronousProgramming
{
    internal class Program
    {
        static async Task<int> FirstMethod()
        {
            int a = 5;
            Console.WriteLine("1st method execution started");
            /*Thread.Sleep(5000);*/
            await Task.Delay(1000);
           
            Console.WriteLine("1st Method Execiton Completed");
            return a;
        }
        static void SecondMethod()
        {

            Console.WriteLine("2nd method execution started");
            /*  await Task.Delay(2000);*/
            Console.WriteLine("2nd Method Execiton Completed");
        }
        static async Task Main(string[] args)
        {
          var b =   FirstMethod();
          

            SecondMethod();
          //  var c = await b;

            Console.WriteLine(b.Result);

            Console.ReadKey();
        }
    }
}
