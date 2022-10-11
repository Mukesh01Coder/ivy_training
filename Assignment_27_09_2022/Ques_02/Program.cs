using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ques_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw1 = new StreamWriter("C:\\Users\\Mukesh.Lodha\\OneDrive - Entain Group\\Desktop\\ivy_training\\Assignment_27_09_2022\\Ques_02\\test.txt");

            StreamWriter sw2 = new StreamWriter("C:\\Users\\Mukesh.Lodha\\OneDrive - Entain Group\\Desktop\\ivy_training\\Assignment_27_09_2022\\test.txt");

            for(int i = 0; i < 5; i++)
            {
                string name = Console.ReadLine();
                sw1.WriteLine(name);
            }
            sw1.Close();

            

            StreamReader sr1 = new StreamReader("C:\\Users\\Mukesh.Lodha\\OneDrive - Entain Group\\Desktop\\ivy_training\\Assignment_27_09_2022\\Ques_02\\test.txt");

           sw2.WriteLine(sr1.ReadToEnd());  
            sr1.Close();
            sw2.Close();
        }
    }
}
