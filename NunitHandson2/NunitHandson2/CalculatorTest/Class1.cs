using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NunitHandson2;

namespace CalculatorTest
{
    [TestFixture]
    public class Class1
    {
        [Test, Category("MathA"), Order(1),Description("1st will be tested")]
        //[TestCase(100, 60, 160)]
        [AuthorAttribute("Vineeth")]
       [AuthorAttribute("Vineethpunga@gmail.com")]
        //[TestCaseSource(nameof(AddCases))]
        [TestCaseSource(typeof(AddCases))]


        public void AddTest(int n1,int n2)
        {
            Calculator calc = new Calculator();
            int result = calc.Add(n1, n2);
            Assert.That(result, Is.EqualTo(n1+n2));
        }
        //static readonly object[] AddCases =
        //{
        //    new object[]{1,1},
        //    new object[]{50,50},
        //    new object[]{22,13}

        //};
        class AddCases:IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { 1, 1 };
                yield return new object[] { 50, 50 };
                yield return new object[] { 22, 13 };
            }
        }

        [Test, Category("MathB"), Order(4), Description("4th will be tested")]
        [TestCase(100, 60, 40)]
        [AuthorAttribute("Vineeth")]
        [AuthorAttribute("Vineethpunga@gmail.com")]
        public void SubstarctionTest(int n1, int n2, int expected)
        {
            Calculator calc = new Calculator();
            int result = calc.Substract(n1, n2);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test, Category("MathC"), Order(3), Description("3rd will be tested")]
        [TestCase(100, 60, 6000)]
        [AuthorAttribute("Vineeth")]
        [AuthorAttribute("Vineethpunga@gmail.com")]
        public void MultipleTest(int n1, int n2, int expected)
        {
            Calculator calc = new Calculator();
            int result = calc.Multiply(n1, n2);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test, Category("MathD"), Order(2), Description("2nd will be tested")]
        [TestCase(100, 60, 1)]
        [AuthorAttribute("Vineeth")]
        [AuthorAttribute("Vineethpunga@gmail.com")]
        [Ignore("Ignore the DivideTest Method")]
        public void DivideTest(int n1, int n2, int expected)
        {
            Calculator calc = new Calculator();
            int result = calc.Divide(n1, n2);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
