using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a C# program to create a file with a name given by the user. Add atleast 10 lines of content to the file. 
Get 2 inputs from the user, old word and new word and replace the old word with the new word throughout the file.
You can show a little bit of content to the user as hints for the old word.*/

namespace Ques_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Mukesh.Lodha\OneDrive - Entain Group\Desktop\ivy_training\Assignment_30_09_2022\Ques_08\new.txt";
           // FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
         //  StreamWriter sw = new StreamWriter(path);

            try
            {
                StreamWriter sw = File.AppendText(path);



                sw.WriteLine("The first line has been added");
                sw.WriteLine("Second line");
                sw.WriteLine("Third Line");
                sw.WriteLine("fourth line has been added");
                sw.WriteLine("The fifth line has been added");
                sw.WriteLine("The sixth line has been added");
                sw.WriteLine("The seventh line has been added");
                sw.WriteLine("The eighth line has been added");
                sw.WriteLine("The ninth line has been added");
                sw.WriteLine("The tenth line has been added");
                sw.WriteLine("The eleventh line has been added");
                sw.Close();



            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Enter the text you wanna replaced");
            string OldText = Console.ReadLine();



            Console.WriteLine("Enter the text you want in the file");
            string NewText = Console.ReadLine();



            string text = File.ReadAllText(path);
            text = text.Replace(OldText, NewText);
            File.WriteAllText(path, text); 
            Console.ReadKey();





            Console.ReadKey();


        }
    }
}
