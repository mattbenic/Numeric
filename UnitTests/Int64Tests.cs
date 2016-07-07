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
    public class Int64NumericTests
    {
        [TestMethod]
        public void TestAddMethod()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            long expected = input1 + input2;

            long actual = Numeric<long>.Add(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddOperator()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            long expected = input1 + input2;

            long actual = ((Numeric<long>)input1) + ((Numeric<long>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractMethod()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            long expected = input1 - input2;

            long actual = Numeric<long>.Subtract(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractOperator()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            long expected = input1 - input2;

            long actual = ((Numeric<long>)input1) - ((Numeric<long>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyMethod()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            long expected = input1 * input2;

            long actual = Numeric<long>.Multiply(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyOperator()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            long expected = input1 * input2;

            long actual = ((Numeric<long>)input1) * ((Numeric<long>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivisionMethod()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            long expected = input1 / input2;

            long actual = Numeric<long>.Division(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivisionOperator()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            long expected = input1 / input2;

            long actual = ((Numeric<long>)input1) / ((Numeric<long>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUnaryNegationMethod()
        {
            var rand = new Random();
            long input = rand.Next();
            long expected = -input;

            long actual = Numeric<long>.UnaryNegation(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUnaryNegationOperator()
        {
            var rand = new Random();
            long input = rand.Next();
            long expected = -input;

            long actual = -((Numeric<long>)input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualsMethod()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            bool expected = input1 == input2;

            bool actual = ((Numeric<long>)input1).Equals(input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualityMethod()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            bool expected = input1 == input2;

            bool actual = Numeric<long>.Equality(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualityOperator()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            bool expected = input1 == input2;

            bool actual = ((Numeric<long>)input1) == ((Numeric<long>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInequalityMethod()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            bool expected = input1 != input2;

            bool actual = Numeric<long>.Inequality(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInequalityOperator()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            bool expected = input1 != input2;

            bool actual = ((Numeric<long>)input1) != ((Numeric<long>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanMethod()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            bool expected = input1 < input2;

            bool actual = Numeric<long>.LessThan(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOperator()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            bool expected = input1 < input2;

            bool actual = ((Numeric<long>)input1) < ((Numeric<long>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanMethod()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            bool expected = input1 > input2;

            bool actual = Numeric<long>.GreaterThan(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOperator()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            bool expected = input1 > input2;

            bool actual = ((Numeric<long>)input1) > ((Numeric<long>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOrEqualMethod()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            bool expected = input1 <= input2;

            bool actual = Numeric<long>.LessThanOrEqual(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOrEqualOperator()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            bool expected = input1 <= input2;

            bool actual = ((Numeric<long>)input1) <= ((Numeric<long>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualMethod()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            bool expected = input1 >= input2;

            bool actual = Numeric<long>.GreaterThanOrEqual(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualOperator()
        {
            var rand = new Random();
            long input1 = rand.Next();
            long input2 = rand.Next();
            bool expected = input1 >= input2;

            bool actual = ((Numeric<long>)input1) >= ((Numeric<long>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetHashCodeMethodIsConsistent()
        {
            var rand = new Random();
            long input = rand.Next();
            int expected = ((Numeric<long>)input).GetHashCode();

            int actual = ((Numeric<long>)input).GetHashCode();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringMethod()
        {
            var rand = new Random();
            long input = rand.Next();
            string expected = input.ToString();

            string actual = ((Numeric<long>)input).ToString();

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class Int64MathTests
    {
        [TestMethod]
        public void TestAbsMethodPositive()
        {
            var rand = new Random();
            long input = (long)rand.Next(0, int.MaxValue);
            long expected = input;

            long actual = Math<long>.Abs(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAbsMethodNegative()
        {
            var rand = new Random();
            long input = (long)rand.Next(int.MinValue, -1);
            long expected = (long)-input;

            long actual = Math<long>.Abs(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClampMethodLessThan()
        {
            var rand = new Random();
            long min = (long)rand.Next();
            long max = (long)rand.Next((int) min, int.MaxValue);
            long input = (long)rand.Next(int.MinValue, (int) min);
            long expected = min;

            long actual = Math<long>.Clamp(input, min, max);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClampMethodMoreThan()
        {
            var rand = new Random();
            long min = (long)rand.Next();
            long max = (long)rand.Next((int) min, int.MaxValue);
            long input = (long)rand.Next((int) max, int.MaxValue);
            long expected = max;

            long actual = Math<long>.Clamp(input, min, max);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClampMethodInside()
        {
            var rand = new Random();
            long min = (long)rand.Next();
            long max = (long)rand.Next((int) min, int.MaxValue);
            long input = (long)rand.Next((int) min, (int) max);
            long expected = input;

            long actual = Math<long>.Clamp(input, min, max);

            Assert.AreEqual(expected, actual);
        }
    }
}
