using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a C# program that implements an IVehicle interface with two methods, one for Drive of type void and another for Refuel of type bool. 
The Refuel method takes an input parameter of type integer with the amount of petrol/diesel to refuel. 
Then create a Car class with a builder that receives a parameter with the car's starting fuel(petrol/diesel) amount and implements
 the Drive and Refuel methods of the car.

The Drive method will print on the screen that the car is Driving, if the fuel(petrol/diesel) is greater than 0.
The Refuel method will increase the fuel(petrol/diesel) of the car and return true.

To carry out the tests, create an object of type Car with 0 of fuel(petrol/diesel) in the Main program 
and ask the user for an amount of fuel(petrol/diesel) to refuel, finally execute the Drive method of the car.*/
namespace Ques_03
{
    public interface IVehicle
    {
        void Drive();
        bool Refuel(int amount);
    }

    public class Car : IVehicle
    {
        public int fuel;

      
        public void Drive()
        {
            if (fuel > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Not fuel");
            }
        }

        public bool Refuel(int amount)
        {
            fuel += amount;
            return true;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();

            int fuel = int.Parse(Console.ReadLine());
            if (car.Refuel(fuel))
            {
                car.Drive();
            }
        }

       
       
    }
}