using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            DirectoryInfo di = Directory.CreateDirectory("C:\\Users\\Mukesh.Lodha\\OneDrive - Entain Group\\Desktop\\ivy_training\\Assignment_27_09_2022\\People Info");

            

            string path = "C:\\Users\\Mukesh.Lodha\\OneDrive - Entain Group\\Desktop\\ivy_training\\Assignment_27_09_2022\\People Info";
            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine($"Enter the name of File{j}:");
                string name1 = Console.ReadLine();
                StreamWriter  sw = new StreamWriter($"{path}\\{name1}.txt");
                for (int i = 1; i <= 5; i++)
                {


                    Console.WriteLine($"Enter the name of person {i}: ");
                    string name = Console.ReadLine();



                    Console.WriteLine("Enter the age of person: ");
                    int age = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the place of origin: ");
                    string place = Console.ReadLine();



                    Console.WriteLine("Enter the number of language: ");
                    int num_of_lang = int.Parse(Console.ReadLine());

                    sw.WriteLine(name + ": [" + age + " ," + place + ", " + num_of_lang + "]");
                }
                sw.Close();
                j++;
            }
           

        }
    }
}
