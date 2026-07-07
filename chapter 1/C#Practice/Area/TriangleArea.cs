using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.Area
{
    public class TriangleArea
    {
        int baseLenght, height;
       public void Accept()
        {
            Console.WriteLine("Enter the baseLenght : ");
            baseLenght = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the height : ");
            height = Convert.ToInt32(Console.ReadLine());
        }

        public void AreaOfTriangle()
        {
            int area = (baseLenght * height) / 2;
            Console.WriteLine("the area of Triangle : " + area);
        }
    }
}
