using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*Write a C# program that uses a Queue to store a list of people. Create a class called Person.cs with two properties (name and age) 
and a ToString() method to print the result.*/
namespace Ques_07
{
   public class person
    {
        public string name;
        public int age;
       
        public void set_value(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public  void Tostring()
        {
            Console.WriteLine($" Name of the person : {name}\n Age of the person: {age} ");
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            person p = new person();
            Queue<string> queue = new Queue<string>();
            Queue<int> queue2 = new Queue<int>();

            Console.WriteLine("Enter the Size of List: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
               
                Console.WriteLine("Enter the Name of Person: ");
                string name = Console.ReadLine();
                queue.Enqueue(name);


                Console.WriteLine("Enter the Age  of Person: ");
                int age = int.Parse(Console.ReadLine());
                queue2.Enqueue(age);  

            }

            for(int i = 0; i < n; i++)
            {
                string name1 = queue.Dequeue();
                int age1 = queue2.Dequeue();

                p.set_value(name1, age1);
                p.Tostring();
            }
        }
    }
}
