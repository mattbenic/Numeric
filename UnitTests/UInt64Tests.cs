/*
https://github.com/mattbenic/Numeric
Copyright(c) 2014 Matt Benic

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeric;

namespace UnitTests
{
    [TestClass]
    public class UInt64NumericTests
    {
        [TestMethod]
        public void TestAddMethod()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            ulong expected = input1 + input2;

            ulong actual = Numeric<ulong>.Add(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddOperator()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            ulong expected = input1 + input2;

            ulong actual = ((Numeric<ulong>)input1) + ((Numeric<ulong>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractMethod()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            ulong expected = input1 - input2;

            ulong actual = Numeric<ulong>.Subtract(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractOperator()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            ulong expected = input1 - input2;

            ulong actual = ((Numeric<ulong>)input1) - ((Numeric<ulong>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyMethod()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            ulong expected = input1 * input2;

            ulong actual = Numeric<ulong>.Multiply(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyOperator()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            ulong expected = input1 * input2;

            ulong actual = ((Numeric<ulong>)input1) * ((Numeric<ulong>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivisionMethod()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            ulong expected = input1 / input2;

            ulong actual = Numeric<ulong>.Division(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivisionOperator()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            ulong expected = input1 / input2;

            ulong actual = ((Numeric<ulong>)input1) / ((Numeric<ulong>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<ulong>))]
        public void TestUnaryNegationMethod()
        {
            var rand = new Random();
            ulong input = (ulong)rand.Next();

            ulong actual = Numeric<ulong>.UnaryNegation(input);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<ulong>))]
        public void TestUnaryNegationOperator()
        {
            var rand = new Random();
            ulong input = (ulong)rand.Next();

            ulong actual = -((Numeric<ulong>)input);
        }

        [TestMethod]
        public void TestEqualsMethod()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            bool expected = input1 == input2;

            bool actual = ((Numeric<ulong>)input1).Equals(input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualityMethod()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            bool expected = input1 == input2;

            bool actual = Numeric<ulong>.Equality(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualityOperator()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            bool expected = input1 == input2;

            bool actual = ((Numeric<ulong>)input1) == ((Numeric<ulong>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInequalityMethod()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            bool expected = input1 != input2;

            bool actual = Numeric<ulong>.Inequality(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInequalityOperator()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            bool expected = input1 != input2;

            bool actual = ((Numeric<ulong>)input1) != ((Numeric<ulong>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanMethod()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            bool expected = input1 < input2;

            bool actual = Numeric<ulong>.LessThan(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOperator()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            bool expected = input1 < input2;

            bool actual = ((Numeric<ulong>)input1) < ((Numeric<ulong>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanMethod()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            bool expected = input1 > input2;

            bool actual = Numeric<ulong>.GreaterThan(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOperator()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            bool expected = input1 > input2;

            bool actual = ((Numeric<ulong>)input1) > ((Numeric<ulong>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOrEqualMethod()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            bool expected = input1 <= input2;

            bool actual = Numeric<ulong>.LessThanOrEqual(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOrEqualOperator()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            bool expected = input1 <= input2;

            bool actual = ((Numeric<ulong>)input1) <= ((Numeric<ulong>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualMethod()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            bool expected = input1 >= input2;

            bool actual = Numeric<ulong>.GreaterThanOrEqual(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualOperator()
        {
            var rand = new Random();
            ulong input1 = (ulong)rand.Next();
            ulong input2 = (ulong)rand.Next();
            bool expected = input1 >= input2;

            bool actual = ((Numeric<ulong>)input1) >= ((Numeric<ulong>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetHashCodeMethodIsConsistent()
        {
            var rand = new Random();
            ulong input = (ulong)rand.Next();
            int expected = ((Numeric<ulong>)input).GetHashCode();

            int actual = ((Numeric<ulong>)input).GetHashCode();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringMethod()
        {
            var rand = new Random();
            ulong input = (ulong)rand.Next((int) ulong.MinValue, int.MaxValue);
            string expected = input.ToString();

            string actual = ((Numeric<ulong>)input).ToString();

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class UInt64MathTests
    {
        [TestMethod]
        public void TestAbsMethodPositive()
        {
            var rand = new Random();
            ulong input = (ulong)rand.Next(0, int.MaxValue);
            ulong expected = input;

            ulong actual = Math<ulong>.Abs(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClampMethodLessThan()
        {
            var rand = new Random();
            ulong min = (ulong)rand.Next((int)ulong.MinValue, int.MaxValue);
            ulong max = (ulong)rand.Next((int)min, int.MaxValue);
            ulong input = (ulong)rand.Next((int)ulong.MinValue, (int)min);
            ulong expected = min;

            ulong actual = Math<ulong>.Clamp(input, min, max);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClampMethodMoreThan()
        {
            var rand = new Random();
            ulong min = (ulong)rand.Next((int)ulong.MinValue, int.MaxValue);
            ulong max = (ulong)rand.Next((int)min, int.MaxValue);
            ulong input = (ulong)rand.Next((int)max, int.MaxValue);
            ulong expected = max;

            ulong actual = Math<ulong>.Clamp(input, min, max);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClampMethodInside()
        {
            var rand = new Random();
            ulong min = (ulong)rand.Next();
            ulong max = (ulong)rand.Next((int)min, int.MaxValue);
            ulong input = (ulong)rand.Next((int)min, (int)max);
            ulong expected = input;

            ulong actual = Math<ulong>.Clamp(input, min, max);

            Assert.AreEqual(expected, actual);
        }
    }
}
