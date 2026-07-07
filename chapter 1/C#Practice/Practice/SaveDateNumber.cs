using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.Practice
{
    public class SaveDateNumber
    {
        public  void SaveDateN()
        {
            String Date = "01082024";
            int d = Convert.ToInt32(Date);
            int first = d % 10;
            int secont = d % 10;
            int third = d % 10;
            int fourth = d % 10;
            int fifth = d % 10;
            int sixth = d % 10;
            int seventh = d % 10;
            int eighth = d % 10; 

            int savedate = first + secont + third + fourth + fifth + sixth + seventh + eighth; 
            Console.WriteLine("Saved Date Number is : " + savedate);

        }
    }
}
