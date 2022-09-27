using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "MUKESH kumar LOdha";

            int len = str1.Length;

            string str2 = " ";
            int i = 0;
            while ( i< len)
            {
                if (Char.IsLower(str1[i]))
                {
                   str2 = str2 + Char.ToUpper(str1[i]);
                }else if (Char.IsUpper(str1[i]))
                {
                   str2 = str2 + Char.ToLower(str1[i]);
                }
                else
                {
                    str2 = str2 + " ";
                }
                i++;
            }
            Console.WriteLine(str2);
        }
    }
}
