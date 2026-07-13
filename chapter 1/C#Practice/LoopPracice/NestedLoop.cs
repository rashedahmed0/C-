using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.LoopPracice
{
    public class NestedLoop
    {
        public void NestedLoopExample()
        {
            for(int i = 1; i < 5; i++)
            {
                for(int j = 1; j <=1; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
