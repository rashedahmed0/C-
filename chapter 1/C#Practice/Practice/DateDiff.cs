using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.Practice
{
    public class DateDiff
    {
        public void DateDifference()
        {

            String Date1 = "01072026";
            String Date2 = "01072024";
            int d1 = Convert.ToInt32(Date1);
            int d2 = Convert.ToInt32(Date2);
            int y1 = d1 % 10000;
            int y2 = d2 % 10000;
            int dateDiff = y1 - y2;
            Console.WriteLine("Date Difference is : " + dateDiff);





            //DateTime date1 = new DateTime(2020, 1, 1);
            //DateTime date2 = new DateTime(2023, 6, 1);
            //TimeSpan difference = date2 - date1;
            //Console.WriteLine("Difference in days: " + difference.Days);
            //Console.WriteLine("Difference in months: " + (difference.Days / 30));
            //Console.WriteLine("Difference in years: " + (difference.Days / 365));
        }


    }
}
