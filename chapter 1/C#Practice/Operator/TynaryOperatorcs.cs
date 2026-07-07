using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.Operator
{
    public class TynaryOperatorcs
    {
        public void practiceTynary()
        {
            int a = 5;
            string result = (a % 2 == 0) ? "Even number" : "Odd number ";
            Console.WriteLine(result);
        }
    public void LeapYearCheck()
        {
            int year = 2020;
            string leapYear = (year % 4 == 0) ? "this year is leap Year" : "this year is not a learYear";
            Console.WriteLine(leapYear);

        }
    }

}
