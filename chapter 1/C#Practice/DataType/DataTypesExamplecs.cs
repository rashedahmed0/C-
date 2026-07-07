using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.DataType
{
    public class DataTypesExamplecs
    {
        public void PrimitiveDataTypes()
        {
            int Num = 10;
            float F = 10.5f;
            double D = 2.05;
            char Grade = 'A';
            Console.WriteLine("Num={0} F={1} D={2} Grade={3} ", Num, F, D, Grade);

        }

        public void DerivativeDataTypes()
        {
            Int16 i16 = 10;
            Double d = 20.5;
            String str = "Hello World";
            Char c = 'A';
            Boolean b = true;
            Object o = 0;

            Console.WriteLine("Int16={0} Double={1} String={2} Char={3} Boolean={4} Object={5}", i16, d, str, c, b, o);
        }
    }
}
