using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber_test_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Напишите страку");
            str = Console.ReadLine();
            StringBuilder(str, out string res);
            Console.WriteLine("result: " + res);
            Console.ReadLine();

        }
        static void RemoveDups(string str, out string result)
        {
            char[] chars = str.ToCharArray();

            string res="";
            char last = chars[0];
            res += last;
            for(int i=0; i<chars.Length; i++)
            {
                if(chars[i] == last)
                {

                }
                else
                {
                    last = chars[i];
                    res += last;

                }
            }
            result = res;
        }
    }
}
