using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongNumber
{
    class Program
    {
        static void strongNumber(int x)
        {
            int n = x;
            int fact ;
            int sum = 0;
            for (int i = x; i > 0; i= i/10)
            {
                 fact = 1;
                 for(int j =1; j <= i % 10 ;j++)
                {
                    fact = fact * j;
                }

                sum = sum + fact;
            }
            //Console.WriteLine("summation is : "+ sum);
            if(sum == n)
            {
                Console.WriteLine("Given number is Strong number. ");
            }
            else
            {
                Console.WriteLine("Given number is  not Strong number. ");
            }

        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number to check strong or not :");
            n = Convert.ToInt32(Console.ReadLine());
            strongNumber(n);
        }
    }
}
