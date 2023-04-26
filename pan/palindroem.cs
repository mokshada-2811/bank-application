using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pan
{
    class Program
    {
        static void Main(string []args)
        {
            int r, sum = 0, temp;
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while(n>0)
            {
                r = (n % 10);
                sum = (sum * 10) + r;
                n = (n / 10);
            }
            if (temp==sum)
            {
                Console.WriteLine("it is a palindrome");
            }
            else
            {
                Console.WriteLine("it is not a palindrome");
            }
        }
    }
}
