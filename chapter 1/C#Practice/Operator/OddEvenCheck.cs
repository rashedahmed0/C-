using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace C_Practice.Operator
{
    internal class OddEvenCheck
    {
        int a;
        public void Accept()
        {
            Console.WriteLine("Enter the number : ");
            a= Convert.ToInt32(Console.ReadLine());

        }

        public void CheckOddEvenNumber()
        {
            int  result;
            if(a % 2== 0)
            {
                                
                result = a*a ;
            Console.WriteLine($"The number is {result} number");
                
            }
            else
            {
                result = a * a * a;
                Console.WriteLine($"The number is {result} number");
            }

            //string result = (a % 2 == 0) ? "the number is event " : "the number is Odd";
            //Console.WriteLine(result);
        }
    }
}
