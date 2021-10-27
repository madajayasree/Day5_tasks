using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class Program
    {
        static void palindrom(String x)
        {
            string revs= "";
           // string name = x;
           for(int i = x.Length-1; i >=0;i--)
            {
                revs = revs + x[i].ToString();
            }
            
           if(revs == x)
            {
                Console.WriteLine("Given string is palindrom");
            }
            else
            {
                Console.WriteLine("Given string is not a palindrom");

            }
        }
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("Enter a string: ");
            a = Console.ReadLine();
            palindrom(a);
        }
    }
}
