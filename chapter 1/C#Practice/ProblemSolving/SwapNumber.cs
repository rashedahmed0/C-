using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.ProblemSolving
{
    public class SwapNumber
    {
        static int a = 10, b = 20; 

        public void Swap()
        {
            Console.WriteLine("before swap the number : " + a + " " + b);

            int temp = a;
            a = b;
            b = temp;


            Console.WriteLine("after  swap the number : " + a + " " + b);

        } 
    }
}
