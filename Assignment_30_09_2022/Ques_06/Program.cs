using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to copy the contents of one file to another file and encrypt the new file.
//Have any rule to differentiate the contents along with the encryption. 

namespace Ques_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path1 = "C:\\Users\\Mukesh.Lodha\\OneDrive - Entain Group\\Desktop\\ivy_training\\Assignment_30_09_2022\\Ques_06\\Test.txt";
            StreamWriter sw1 = new StreamWriter(path1);

            string Copy_path = "C:\\Users\\Mukesh.Lodha\\OneDrive - Entain Group\\Desktop\\ivy_training\\Assignment_30_09_2022\\Ques_06\\Copy.txt";
            StreamWriter sw2 = new StreamWriter(Copy_path);

            for (int i = 0; i < 5; i++)
            {
                string name = Console.ReadLine();
                sw1.WriteLine(name);
            }
            sw1.Close();







            try
            {

                StreamReader sr1 = new StreamReader(path1);

                sw2.WriteLine(sr1.ReadToEnd());
                sr1.Close();
                sw2.Close();

                StreamReader sr2 = new StreamReader(Copy_path);

                Console.WriteLine(sr2.ReadToEnd());
                sr2.Close();
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }

        }
    }
}
