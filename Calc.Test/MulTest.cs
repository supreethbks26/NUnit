using NUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Test
{
    [TestFixture]
    public class MulTest
    {
        [TestCase(0,0,0)]
        [TestCase(100,10,10)]
        [TestCase(-100,100,-1)]
        [Test]

        public void shouldmul(int ans, int n1, int n2)
        {
            Icalc c = new NUnit.Calc();
            Assert.AreEqual(ans, c.mul(n1, n2));
        }


    }
}
