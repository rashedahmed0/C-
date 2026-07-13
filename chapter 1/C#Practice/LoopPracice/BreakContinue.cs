using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.LoopPracice
{
    public class BreakContinue
    {
         public void BreakExample()
        {
            for(int i = 1; i <=10; i++)
            {
                if(i == 5)
                {
                    break;
                }
                Console.WriteLine( "this is breake" + i);

            }

        }

        public void ContinueExample()
        {
            for(int j = 1; j <= 10; j++)
            {
                if(j == 5)
                {
                    continue;
                }
                Console.WriteLine("this is continue" + j);
            }
        }
    }
}
