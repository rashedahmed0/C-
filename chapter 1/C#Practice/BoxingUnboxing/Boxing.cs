using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.BoxingUnboxing
{
    public class Boxing
    {
        public void BoxingExample()
        {
            int a = 10;
            object o;
            o = a;
            Console.WriteLine(o);
        }
        public void UnboxingExample()
        {
            object o = 20;
            int a = (int)0;
            Console.WriteLine(0);
        }
    }
}
