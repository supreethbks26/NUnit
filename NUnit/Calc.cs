using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
   public class Calc : Icalc
    {
        public int add(string num1, string num2)
        {
            //if (int.TryParse(num1, out int n1) && int.TryParse(num2, out int n2))
            //{
            return (int.Parse(num1) + int.Parse(num2));
           // }
            //else throw new ArgumentException("Invalid Input");
        }

        public int mul(int num1, int num2)
        {
            return num1 * num2;
        }
    }

}
