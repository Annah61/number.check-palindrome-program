using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace number.check_palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,temp, revNum = 0;int rem; 
            Console.WriteLine("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num; //121
            while (num > 0)
            {
                rem = num % 10; //1
                revNum = revNum * 10 + rem; //12
                num = num / 10; //1
            }
            if (revNum == temp)
                Console.WriteLine("Number is palindrome");
            else
                Console.WriteLine("Number is not palindrome");

            Console.ReadLine();
        }
    }
}
