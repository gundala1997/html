using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnitHandson1;

namespace CaluculatedTest
{
    [TestFixture]
    public class Class1
    {
        //[Test]
        //public void AddMethodTest()
        //{
        //    Calculator add = new Calculator();
        //    int result = add.Add(15, 65);
        //    Assert.AreEqual(80, result);
        //}
        [Test]
        [TestCase(120, 60, 180)]
        public void addMethodTest(int n1, int n2, int expected)
        {
            Calculator add = new Calculator();
            int x = 0;
            if (x > n1 && x > n2)
            {
                int result = add.Add(n1, n2);
                Assert.AreEqual(expected, result);
            }
            //int x = 0;
            //Assert.Greater(x, n1);
            //Assert.Greater(x, n2);
        }
        [Test]
        [TestCase(120, 1)]

        public void checkGreaterThanZeroTest(int n1, int n2)
        {
            Calculator add = new Calculator();
            int x = 0;
            Assert.That(n1, Is.GreaterThan(0));
            Assert.That(n2, Is.GreaterThan(0));
        }
        
    }
}
