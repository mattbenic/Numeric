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
    public class UInt16NumericTests
    {
        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<ushort>))]
        public void TestAddMethodThrowsException()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();

            ushort actual = Numeric<ushort>.Add(input1, input2);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<ushort>))]
        public void TestAddOperator()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();

            ushort actual = ((Numeric<ushort>)input1) + ((Numeric<ushort>)input2);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<ushort>))]
        public void TestSubtractMethod()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();
            ushort actual = Numeric<ushort>.Subtract(input1, input2);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<ushort>))]
        public void TestSubtractOperator()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();

            ushort actual = ((Numeric<ushort>)input1) - ((Numeric<ushort>)input2);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<ushort>))]
        public void TestMultiplyMethod()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();

            ushort actual = Numeric<ushort>.Multiply(input1, input2);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<ushort>))]
        public void TestMultiplyOperator()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();

            ushort actual = ((Numeric<ushort>)input1) * ((Numeric<ushort>)input2);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<ushort>))]
        public void TestDivisionMethod()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();

            ushort actual = Numeric<ushort>.Division(input1, input2);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<ushort>))]
        public void TestDivisionOperator()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();

            ushort actual = ((Numeric<ushort>)input1) / ((Numeric<ushort>)input2);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<ushort>))]
        public void TestUnaryNegationMethod()
        {
            var rand = new Random();
            ushort input = (ushort)rand.Next();

            ushort actual = Numeric<ushort>.UnaryNegation(input);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<ushort>))]
        public void TestUnaryNegationOperator()
        {
            var rand = new Random();
            ushort input = (ushort)rand.Next();

            ushort actual = -((Numeric<ushort>)input);
        }

        [TestMethod]
        public void TestEqualsMethod()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();
            bool expected = input1 == input2;

            bool actual = ((Numeric<ushort>)input1).Equals(input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualityMethod()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();
            bool expected = input1 == input2;

            bool actual = Numeric<ushort>.Equality(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualityOperator()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();
            bool expected = input1 == input2;

            bool actual = ((Numeric<ushort>)input1) == ((Numeric<ushort>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInequalityMethod()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();
            bool expected = input1 != input2;

            bool actual = Numeric<ushort>.Inequality(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInequalityOperator()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();
            bool expected = input1 != input2;

            bool actual = ((Numeric<ushort>)input1) != ((Numeric<ushort>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanMethod()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();
            bool expected = input1 < input2;

            bool actual = Numeric<ushort>.LessThan(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOperator()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();
            bool expected = input1 < input2;

            bool actual = ((Numeric<ushort>)input1) < ((Numeric<ushort>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanMethod()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();
            bool expected = input1 > input2;

            bool actual = Numeric<ushort>.GreaterThan(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOperator()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();
            bool expected = input1 > input2;

            bool actual = ((Numeric<ushort>)input1) > ((Numeric<ushort>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOrEqualMethod()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();
            bool expected = input1 <= input2;

            bool actual = Numeric<ushort>.LessThanOrEqual(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOrEqualOperator()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();
            bool expected = input1 <= input2;

            bool actual = ((Numeric<ushort>)input1) <= ((Numeric<ushort>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualMethod()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();
            bool expected = input1 >= input2;

            bool actual = Numeric<ushort>.GreaterThanOrEqual(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualOperator()
        {
            var rand = new Random();
            ushort input1 = (ushort)rand.Next();
            ushort input2 = (ushort)rand.Next();
            bool expected = input1 >= input2;

            bool actual = ((Numeric<ushort>)input1) >= ((Numeric<ushort>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetHashCodeMethodIsConsistent()
        {
            var rand = new Random();
            ushort input = (ushort)rand.Next();
            int expected = ((Numeric<ushort>)input).GetHashCode();

            int actual = ((Numeric<ushort>)input).GetHashCode();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringMethod()
        {
            var rand = new Random();
            ushort input = (ushort) rand.Next(ushort.MinValue, ushort.MaxValue);
            string expected = input.ToString();

            string actual = ((Numeric<ushort>)input).ToString();

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class UInt16MathTests
    {
        [TestMethod]
        public void TestAbsMethodPositive()
        {
            var rand = new Random();
            ushort input = (ushort)rand.Next(0, ushort.MaxValue);
            ushort expected = input;

            ushort actual = Math<ushort>.Abs(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClampMethodLessThan()
        {
            var rand = new Random();
            ushort min = (ushort)rand.Next();
            ushort max = (ushort)rand.Next(min, ushort.MaxValue);
            ushort input = (ushort)rand.Next(ushort.MinValue, min);
            ushort expected = min;

            ushort actual = Math<ushort>.Clamp(input, min, max);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClampMethodMoreThan()
        {
            var rand = new Random();
            ushort min = (ushort)rand.Next();
            ushort max = (ushort)rand.Next(min, ushort.MaxValue);
            ushort input = (ushort)rand.Next(max, ushort.MaxValue);
            ushort expected = max;

            ushort actual = Math<ushort>.Clamp(input, min, max);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClampMethodInside()
        {
            var rand = new Random();
            ushort min = (ushort)rand.Next();
            ushort max = (ushort)rand.Next(min, ushort.MaxValue);
            ushort input = (ushort)rand.Next(min, max);
            ushort expected = input;

            ushort actual = Math<ushort>.Clamp(input, min, max);

            Assert.AreEqual(expected, actual);
        }
    }
}
