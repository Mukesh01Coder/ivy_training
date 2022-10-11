using System;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;



namespace ConsoleApp1
{
    class Class1
    {
        static void Main(string[] args)
        {



            string h = Console.ReadLine();
            string go = "";
            try
            {
                StreamReader sw = new StreamReader("C:\\Users\\Mukesh.Lodha\\OneDrive - Entain Group\\Desktop\\ivy_training\\Assignment_27_09_2022\\" + h);




                while ((go = sw.ReadLine()) != null)
                {
                    Console.WriteLine(" the i " + go);
                }
                int e = Convert.ToInt32(Console.ReadLine());
                int t = 3 / e;
                Console.WriteLine(t);
                sw.Close();
                int u = int.Parse(sw.ReadLine());
                Console.WriteLine(u);
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.ToString());



            }
            catch (ObjectDisposedException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.ToString());
            }




            // Read and show each line from the file.



        }
    }
}