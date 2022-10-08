using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create a C# program to:
The main task is to get a stage / event ready with the following tasks:
Flower decorations to be completed on stage.
Chief guest to be picked up from the airport. 
Co-ordinate with the caterers and set up the food area. 
Arrange the gifts to be distributed in the stage after the decorations are over. 
Start the function only when the Chief guest has arrived at the venue. */

namespace Ques_10
{
    internal class Program
    {
        public static  void Flower()
        {
            Console.WriteLine("Flower decorations to be completed on stage.");
        }
        public static bool cheif_guest()
        {
           return true;

        }
        public static async void Food_area()
        {
            await Task.Delay(3000);
            Console.WriteLine("Co-ordinate with the caterers and set up the food area.");
        }

        public static void Arrange()
        {
            Console.WriteLine("Arrange the gifts to be distributed in the stage after the decorations are over.");

        }


        static async Task Main(string[] args)
        {
               if(cheif_guest()){
                    Console.WriteLine("Chief guest to be picked up from the airport");
                      Flower();
                      Food_area();
                      Arrange();
               }else{
                      Console.WriteLine("Chief guest has not come!");
               }
           
             
           
           

            Console.ReadKey();
        }
    }
}
