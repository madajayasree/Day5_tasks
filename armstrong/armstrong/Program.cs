using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong
{
    class Program
    {
        static bool Armstrong(int num)
        {
            int r, sum = 0, temp=num;
            while(num >0)
            {
                r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
            }
            //Console.WriteLine(sum);
            if(sum == temp)
            {
                return true ;
            }
            else
            {
                return false;
            }

            //return true;
        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number :");
            num = Convert.ToInt32(Console.ReadLine());
           Boolean a = Armstrong(num);
            Console.WriteLine(a);
        }
    }
}
