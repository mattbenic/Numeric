using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeric;

namespace UnitTests
{
    [TestClass]
    public class UInt64Tests
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
    }
}
