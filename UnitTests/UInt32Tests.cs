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
    public class UInt32NumericTests
    {
        [TestMethod]
        public void TestAddMethod()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            uint expected = input1 + input2;

            uint actual = Numeric<uint>.Add(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddOperator()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            uint expected = input1 + input2;

            uint actual = ((Numeric<uint>)input1) + ((Numeric<uint>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractMethod()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            uint expected = input1 - input2;

            uint actual = Numeric<uint>.Subtract(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractOperator()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            uint expected = input1 - input2;

            uint actual = ((Numeric<uint>)input1) - ((Numeric<uint>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyMethod()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            uint expected = input1 * input2;

            uint actual = Numeric<uint>.Multiply(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyOperator()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            uint expected = input1 * input2;

            uint actual = ((Numeric<uint>)input1) * ((Numeric<uint>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivisionMethod()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            uint expected = input1 / input2;

            uint actual = Numeric<uint>.Division(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivisionOperator()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            uint expected = input1 / input2;

            uint actual = ((Numeric<uint>)input1) / ((Numeric<uint>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<uint>))]
        public void TestUnaryNegationMethod()
        {
            var rand = new Random();
            uint input = (uint)rand.Next();

            uint actual = Numeric<uint>.UnaryNegation(input);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchOperationException<uint>))]
        public void TestUnaryNegationOperator()
        {
            var rand = new Random();
            uint input = (uint)rand.Next();

            uint actual = -((Numeric<uint>)input);
        }

        [TestMethod]
        public void TestEqualsMethod()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            bool expected = input1 == input2;

            bool actual = ((Numeric<uint>)input1).Equals(input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualityMethod()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            bool expected = input1 == input2;

            bool actual = Numeric<uint>.Equality(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualityOperator()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            bool expected = input1 == input2;

            bool actual = ((Numeric<uint>)input1) == ((Numeric<uint>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInequalityMethod()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            bool expected = input1 != input2;

            bool actual = Numeric<uint>.Inequality(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInequalityOperator()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            bool expected = input1 != input2;

            bool actual = ((Numeric<uint>)input1) != ((Numeric<uint>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanMethod()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            bool expected = input1 < input2;

            bool actual = Numeric<uint>.LessThan(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOperator()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            bool expected = input1 < input2;

            bool actual = ((Numeric<uint>)input1) < ((Numeric<uint>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanMethod()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            bool expected = input1 > input2;

            bool actual = Numeric<uint>.GreaterThan(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOperator()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            bool expected = input1 > input2;

            bool actual = ((Numeric<uint>)input1) > ((Numeric<uint>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOrEqualMethod()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            bool expected = input1 <= input2;

            bool actual = Numeric<uint>.LessThanOrEqual(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOrEqualOperator()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            bool expected = input1 <= input2;

            bool actual = ((Numeric<uint>)input1) <= ((Numeric<uint>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualMethod()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            bool expected = input1 >= input2;

            bool actual = Numeric<uint>.GreaterThanOrEqual(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualOperator()
        {
            var rand = new Random();
            uint input1 = (uint)rand.Next();
            uint input2 = (uint)rand.Next();
            bool expected = input1 >= input2;

            bool actual = ((Numeric<uint>)input1) >= ((Numeric<uint>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetHashCodeMethodIsConsistent()
        {
            var rand = new Random();
            uint input = (uint)rand.Next();
            int expected = ((Numeric<uint>)input).GetHashCode();

            int actual = ((Numeric<uint>)input).GetHashCode();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringMethod()
        {
            var rand = new Random();
            uint input = (uint) rand.Next((int) uint.MinValue, int.MaxValue);
            string expected = input.ToString();

            string actual = ((Numeric<uint>)input).ToString();

            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class UInt32MathTests
    {
        [TestMethod]
        public void TestAbsMethodPositive()
        {
            var rand = new Random();
            uint input = (uint)rand.Next(0, int.MaxValue);
            uint expected = input;

            uint actual = Math<uint>.Abs(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClampMethodLessThan()
        {
            var rand = new Random();
            uint min = (uint)rand.Next((int) uint.MinValue, int.MaxValue);
            uint max = (uint)rand.Next((int) min, int.MaxValue);
            uint input = (uint)rand.Next((int)uint.MinValue, (int) min);
            uint expected = min;

            uint actual = Math<uint>.Clamp(input, min, max);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClampMethodMoreThan()
        {
            var rand = new Random();
            uint min = (uint)rand.Next((int)uint.MinValue, int.MaxValue);
            uint max = (uint)rand.Next((int)min, int.MaxValue);
            uint input = (uint)rand.Next((int) max, int.MaxValue);
            uint expected = max;

            uint actual = Math<uint>.Clamp(input, min, max);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClampMethodInside()
        {
            var rand = new Random();
            uint min = (uint)rand.Next();
            uint max = (uint)rand.Next((int) min, int.MaxValue);
            uint input = (uint)rand.Next((int) min, (int) max);
            uint expected = input;

            uint actual = Math<uint>.Clamp(input, min, max);

            Assert.AreEqual(expected, actual);
        }
    }
}
