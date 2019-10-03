using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzByMJ
{
   public class MathMethods
    {
        public string MathMethod(int number)
        {
            int divisibleBy3 = number % 3;
            int divisibleBy5 = number % 5;


            if (divisibleBy5 == 0 && divisibleBy3 == 0)
            {
                return "3 & 5";

            }
            else if (divisibleBy5 == 0)
            {
                return "5";

            }

            else if (divisibleBy3 == 0)
            {
                return "3";
            }
            else return "false";
        }
    }
}
