using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.Operator
{
    public class IncrementOperator
    {
        public void Incremnet()
        {
            int a = 10;
            int b = 20;

            string result = (a > b) ? "A is greater then b " : " B is greater then a "; 
            Console.WriteLine(result);
            //int b = a++ + a++ + a++;
            //Console.WriteLine("a={0} and b={1}", a, b);

        }
    }
}
