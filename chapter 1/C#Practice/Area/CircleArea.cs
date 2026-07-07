using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.Area
{
    public class CircleArea
    {
        double Pi = 3.1416, radius;

        public void Accept()
        {
            Console.WriteLine("Enter the radius : ");
            radius = Convert.ToInt32( Console.ReadLine());
        }

        public void AreaOfCircle()
        {
            double area = 2 * Pi * radius * radius;
            Console.WriteLine("The area of circle is : " + area);
        }


    }
}
