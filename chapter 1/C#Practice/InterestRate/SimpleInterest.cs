using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.InterestRate
{
    public class SimpleInterest
    {
    int i, p, r, t;
    public void Accept()
    {
            Console.WriteLine("Enter the p : ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the r : ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the t : ");
            t = Convert.ToInt32(Console.ReadLine());

    }

    public void SInterest()
        {
            i = (p * r * t) / 100;
            Console.WriteLine("Simple Interest is : " + i); 
        }


    }
}
