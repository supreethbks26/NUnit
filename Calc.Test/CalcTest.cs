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
    public class CalcTest
    {
        [TestCase(10, "5", "5")]
        [TestCase(100, "50", "50")]
        [TestCase(100, "75", "25")]
        [TestCase(0,"1","-1")]

        [Test]
        public void shouldadd(int ans, string i1, string i2)
        {
            Icalc c = new NUnit.Calc();
            Assert.AreEqual(ans, c.add(i1, i2));
        }
        [Test]
        public void throws()
        {
            Icalc c = new NUnit.Calc();
            Assert.That(() => c.add("a", "b"), Throws.ArgumentException);
        }
    }
}
