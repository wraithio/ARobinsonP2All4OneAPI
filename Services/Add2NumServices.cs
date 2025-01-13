using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARobinsonMC3Two2Four_EndPnt.services
{
    public class Add2NumServices
    {
        public string Add2Num(int Num1, int Num2)
        {
            int sum = Num1 + Num2;
            return "The sum of " + Num1 + " and " + Num2 + " is " + sum + ".";
        }
    }
}