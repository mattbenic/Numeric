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
    public class Int16NumericTests
    {
        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<short>))]
        public void TestAddMethodThrowsException()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();

            short actual = Numeric<short>.Add(input1, input2);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<short>))]
        public void TestAddOperator()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();

            short actual = ((Numeric<short>)input1) + ((Numeric<short>)input2);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<short>))]
        public void TestSubtractMethod()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();
            short actual = Numeric<short>.Subtract(input1, input2);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<short>))]
        public void TestSubtractOperator()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();

            short actual = ((Numeric<short>)input1) - ((Numeric<short>)input2);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<short>))]
        public void TestMultiplyMethod()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();

            short actual = Numeric<short>.Multiply(input1, input2);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<short>))]
        public void TestMultiplyOperator()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();

            short actual = ((Numeric<short>)input1) * ((Numeric<short>)input2);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<short>))]
        public void TestDivisionMethod()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();

            short actual = Numeric<short>.Division(input1, input2);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<short>))]
        public void TestDivisionOperator()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();

            short actual = ((Numeric<short>)input1) / ((Numeric<short>)input2);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<short>))]
        public void TestUnaryNegationMethod()
        {
            var rand = new Random();
            short input = (short)rand.Next();

            short actual = Numeric<short>.UnaryNegation(input);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<short>))]
        public void TestUnaryNegationOperator()
        {
            var rand = new Random();
            short input = (short)rand.Next();

            short actual = -((Numeric<short>)input);
        }

        [TestMethod]
        public void TestEqualsMethod()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();
            bool expected = input1 == input2;

            bool actual = ((Numeric<short>)input1).Equals(input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualityMethod()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();
            bool expected = input1 == input2;

            bool actual = Numeric<short>.Equality(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualityOperator()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();
            bool expected = input1 == input2;

            bool actual = ((Numeric<short>)input1) == ((Numeric<short>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInequalityMethod()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();
            bool expected = input1 != input2;

            bool actual = Numeric<short>.Inequality(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInequalityOperator()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();
            bool expected = input1 != input2;

            bool actual = ((Numeric<short>)input1) != ((Numeric<short>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanMethod()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();
            bool expected = input1 < input2;

            bool actual = Numeric<short>.LessThan(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOperator()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();
            bool expected = input1 < input2;

            bool actual = ((Numeric<short>)input1) < ((Numeric<short>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanMethod()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();
            bool expected = input1 > input2;

            bool actual = Numeric<short>.GreaterThan(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOperator()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();
            bool expected = input1 > input2;

            bool actual = ((Numeric<short>)input1) > ((Numeric<short>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOrEqualMethod()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();
            bool expected = input1 <= input2;

            bool actual = Numeric<short>.LessThanOrEqual(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOrEqualOperator()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();
            bool expected = input1 <= input2;

            bool actual = ((Numeric<short>)input1) <= ((Numeric<short>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualMethod()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();
            bool expected = input1 >= input2;

            bool actual = Numeric<short>.GreaterThanOrEqual(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualOperator()
        {
            var rand = new Random();
            short input1 = (short)rand.Next();
            short input2 = (short)rand.Next();
            bool expected = input1 >= input2;

            bool actual = ((Numeric<short>)input1) >= ((Numeric<short>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetHashCodeMethodIsConsistent()
        {
            var rand = new Random();
            short input = (short)rand.Next();
            int expected = ((Numeric<short>)input).GetHashCode();

            int actual = ((Numeric<short>)input).GetHashCode();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringMethod()
        {
            var rand = new Random();
            short input = (short) rand.Next(short.MinValue, short.MaxValue);
            string expected = input.ToString();

            string actual = ((Numeric<short>)input).ToString();

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class Int16MathTests
    {
        [TestMethod]
        public void TestAbsMethodPositive()
        {
            var rand = new Random();
            short input = (short) rand.Next(0, short.MaxValue);
            short expected = input;

            short actual = Math<short>.Abs(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<short>))]
        public void TestAbsMethodNegative()
        {
            var rand = new Random();
            short input = (short) rand.Next(short.MinValue, -1);
            short expected = (short) -input;

            short actual = Math<short>.Abs(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClampMethodLessThan()
        {
            var rand = new Random();
            short min = (short) rand.Next();
            short max = (short) rand.Next(min, short.MaxValue);
            short input = (short) rand.Next(short.MinValue, min);
            short expected = min;

            short actual = Math<short>.Clamp(input, min, max);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClampMethodMoreThan()
        {
            var rand = new Random();
            short min = (short) rand.Next();
            short max = (short) rand.Next(min, short.MaxValue);
            short input = (short) rand.Next(max, short.MaxValue);
            short expected = max;

            short actual = Math<short>.Clamp(input, min, max);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClampMethodInside()
        {
            var rand = new Random();
            short min = (short) rand.Next();
            short max = (short) rand.Next(min, short.MaxValue);
            short input = (short) rand.Next(min, max);
            short expected = input;

            short actual = Math<short>.Clamp(input, min, max);

            Assert.AreEqual(expected, actual);
        }
    }
}
