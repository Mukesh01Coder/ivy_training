using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*Write a C# program to create a Phonebook. 
The Phonebook should take inputs from the user and store their numbers. 
Also ask for the user age and store their numbers as Students in a sub class. If the user gives a profession, store the numbers in the Service subclass. 
Display the numbers as a collection. 
Input: Rekha, 45, Doctor: Hema, 17 : Dheeraj, 34, Tennis player: Gaurav, 12: Bhavna, 33: Umang 24: Suresh, 66: Soni, 14, Siddhant, 28, Professor.
Output: Students:
Hema, 17, Ph: No
Gaurav, 12, Ph: No
Soni, 14, Ph.No
Services and Professionals:
Rekha, 45, Doctor, Ph.No
Dheeraj, 34, Tennis player, Ph.No
Siddhant, 28, Professor, Ph.No
Citizens:
Bhavna, 33, Ph.No
Umang, 24, Ph.No
Suresh, 66, Ph.No*/

namespace Ques_02
{
  

    internal class Program
    {
        public static void student(string name, int age, long PhNo)
        {
         
                var t1 = Tuple.Create(name, age, PhNo);
            Console.WriteLine("Students: ");
            Console.WriteLine(t1);
          
        }
        public static void professionals(string name, int age,string profession, long PhNo)
        {

            var t2 = Tuple.Create(name, age,profession, PhNo);
            Console.WriteLine("Services and Professionals: ");
            Console.WriteLine(t2);

        }
        public static void Citizes(string name, int age, long PhNo)
        {

            var t3 = Tuple.Create(name, age, PhNo);

            Console.WriteLine("Citizens: ");
            Console.WriteLine(t3);

        }
        static void Main(string[] args)
        {
          
            for(int i = 1; i <= 9; i++)
            {
                Console.WriteLine("Enter The Profession: ");
                string name = Console.ReadLine();
                switch (name)
                {
                    case "Doctor":
                        {
                            Console.WriteLine("Enter The Name Of Doctor");
                            string name1 = Console.ReadLine();
                            Console.WriteLine("Enter the Age of Doctor: ");
                            int age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Phone Num: ");

                            long phNo = int.Parse(Console.ReadLine());
                        professionals(name1, age,name, phNo);
                        break;
                         }

                    case "Tennis player":
                        {
                            Console.WriteLine("Enter The Name Of Doctor");
                            string name1 = Console.ReadLine();
                            Console.WriteLine("Enter the Age of Doctor: ");
                            int age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Phone Num: ");

                            long phNo = int.Parse(Console.ReadLine());
                            professionals(name1, age, name,phNo);
                            break;
                        }

                    case "Professor":
                        {
                            Console.WriteLine("Enter The Name Of Professor");
                            string name1 = Console.ReadLine();
                            Console.WriteLine("Enter the Age of Professor: ");
                            int age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Phone Num: ");

                            long phNo = int.Parse(Console.ReadLine());
                            professionals(name1, age,name, phNo);
                            break;
                        }
                    case "student":
                        {
                            Console.WriteLine("Enter The Name Of Student name");
                            string name1 = Console.ReadLine();
                            Console.WriteLine("Enter the Age of student: ");
                            int age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Phone Num: ");

                            long phNo = int.Parse(Console.ReadLine());
                            professionals(name1, age, name, phNo);
                            break;
                        }
                    case "citizen":
                        {
                            Console.WriteLine("Enter The Name Of Citizen name");
                            string name1 = Console.ReadLine();
                            Console.WriteLine("Enter the Age of citizen: ");
                            int age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Phone Num: ");

                            long phNo = int.Parse(Console.ReadLine());
                            professionals(name1, age, name, phNo);
                            break;
                        }
                }
            }
        }
    }
}
