using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeric;

namespace UnitTests
{
    [TestClass]
    public class Int64Tests
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
            long input1 = (long)rand.Next();
            long input2 = (long)rand.Next();
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
            long input = (long)rand.Next();
            int expected = ((Numeric<long>)input).GetHashCode();

            int actual = ((Numeric<long>)input).GetHashCode();

            Assert.AreEqual(expected, actual);
        }
    }
}
