using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a C# program that implements an abstract class Bird that has a Name property of type text and three methods SetName (string name), GetName and Fly. 
The Eat method will be an abstract method of type void.
You will also need to create a Crow/Parrot class that implements the above Bird class and the Fly method should say that the crow/parrot is flying. 
To test the program ask the user for a bird name and create a new Crow/ Parrot type object from the Main program,
give the Crow/Parrot object a name, and then execute the GetName and Fly methods.
*/
namespace Ques_04
{
    abstract class Bird
    {
        public string Name;
        public  void SetName(string name)
        {
            Name = name;
        }
        public  string GetName()
        {
            return Name;
        }
        public abstract void Fly();

      

    }
     class Crow : Bird
    {
        public override void Fly()
        {
            Console.WriteLine($"{Name} is flying.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Crow();

            Console.WriteLine("Enter the Bird Name: ");
            bird.SetName(Console.ReadLine());

            bird.GetName();

            bird.Fly();
        }
    }
}
