using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.LoopPracice
{
    public class Factorial
    {
        int number;
        public void Accept()
        {
            Console.WriteLine("enter the number for table :");
            number = Convert.ToInt32(Console.ReadLine());

        }



        public void FactorialExample()
        {
            int factorialNumber = 1;
            for(var i = number; i >= 1; i --)
            {
                factorialNumber *= i;
            }
                Console.WriteLine("Factorial of " + number + " is : " + factorialNumber);
        }
    }
}
