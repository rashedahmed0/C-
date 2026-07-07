using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.ConditionStateMnet
{
    public class SwitchCaseConditioncs
    {
       public void SwitchCondition()
        {
            int a = 10;
            switch (a % 2 == 0)
            {
                case true :
                    Console.WriteLine("this is a even number ");
                    break;
                default: Console.WriteLine("this is a odd number ");
                    break;
            }
        }
    }
}
