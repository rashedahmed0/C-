using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.Practice
{
    public class InstanceAndStatic
    {
        public static void fun()
        {
            var a = 10;
            Console.WriteLine("static variable : " + a);
        }

        public void fun1()
        {
            var b = 20;
            Console.WriteLine("Instance variable : " + b);
        }


    }
}
