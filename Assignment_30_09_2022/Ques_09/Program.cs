using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create a C# program to:
Create an Employee class and add about 5 employees. Write a method to give promotion. 
Get a value from the user as a trigger to give promotion to selected employees. Use Delegates
*/
namespace Ques_09
{
      
    public delegate void promotion(string name);
  
    internal class Employee
    {
        public static void Promoted_name(string name)
        {
            Console.WriteLine($"Selected for Promotion: {name}");
        }
        static void Main(string[] args)
        {
            Employee e = new Employee();  
            string name = Console.ReadLine();
            promotion p = new promotion(Promoted_name);

            p("mukesh");
            p("ankit");
            p("soaib");
            p("Blinty");
            p("Raksha");

           
        }
    }
}
