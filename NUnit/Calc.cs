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
            int n1, n2;
            if (int.TryParse(num1, out n1) && int.TryParse(num2, out n2))
            {
                return n1 + n2;
            }
            throw new ArgumentException("Invalid input");
        }

        public int mul(int num1, int num2)
        {
            return num1 * num2;
        }
    }

}
