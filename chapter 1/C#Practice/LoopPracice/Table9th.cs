using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.LoopPracice
{
    public class Table9th
    {
        int number; 
        public void Accept()
        {
            Console.WriteLine("enter the number for table :");
            number = Convert.ToInt32(Console.ReadLine());

        }
        public void Table9()
        {
            for (int i = 1; i <= 10; i++) {
                var table = number * i;
                Console.WriteLine(number + " X " + i + " = " + table);
            }
        }
    }
}
