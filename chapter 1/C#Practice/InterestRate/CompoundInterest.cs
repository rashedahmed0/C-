using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.InterestRate
{
    public class CompoundInterest
    {
        double p, t , a ;
        double r, n; 

        public void Accept()
        {
            Console.WriteLine("Enter the Principal (P) :");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the time year (t) :");
            t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Interest rate (r) :");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the nubmer of interest (n) :");
            n = Convert.ToDouble(Console.ReadLine());
        }

        public void CInterest()
        {
            a = p * Math.Pow(1 + (r / n),n * t);
            Console.WriteLine("Compund interest is : " + a) ;
        }






    }
}
