using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeric;

namespace UnitTests
{
    [TestClass]
    public class DecimalTests
    {
        [TestMethod]
        public void TestAddMethod()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            decimal expected = input1 + input2;

            decimal actual = Numeric<decimal>.Add(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddOperator()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            decimal expected = input1 + input2;

            decimal actual = ((Numeric<decimal>)input1) + ((Numeric<decimal>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractMethod()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            decimal expected = input1 - input2;

            decimal actual = Numeric<decimal>.Subtract(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractOperator()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            decimal expected = input1 - input2;

            decimal actual = ((Numeric<decimal>)input1) - ((Numeric<decimal>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyMethod()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            decimal expected = input1 * input2;

            decimal actual = Numeric<decimal>.Multiply(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyOperator()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            decimal expected = input1 * input2;

            decimal actual = ((Numeric<decimal>)input1) * ((Numeric<decimal>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivisionMethod()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            decimal expected = input1 / input2;

            decimal actual = Numeric<decimal>.Division(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivisionOperator()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            decimal expected = input1 / input2;

            decimal actual = ((Numeric<decimal>)input1) / ((Numeric<decimal>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUnaryNegationMethod()
        {
            var rand = new Random();
            decimal input = rand.Next();
            decimal expected = -input;

            decimal actual = Numeric<decimal>.UnaryNegation(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUnaryNegationOperator()
        {
            var rand = new Random();
            decimal input = rand.Next();
            decimal expected = -input;

            decimal actual = -((Numeric<decimal>)input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualsMethod()
        {
            var rand = new Random();
            decimal input1 = (decimal)rand.Next();
            decimal input2 = (decimal)rand.Next();
            bool expected = input1 == input2;

            bool actual = ((Numeric<decimal>)input1).Equals(input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualityMethod()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            bool expected = input1 == input2;

            bool actual = Numeric<decimal>.Equality(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualityOperator()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            bool expected = input1 == input2;

            bool actual = ((Numeric<decimal>)input1) == ((Numeric<decimal>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInequalityMethod()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            bool expected = input1 != input2;

            bool actual = Numeric<decimal>.Inequality(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInequalityOperator()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            bool expected = input1 != input2;

            bool actual = ((Numeric<decimal>)input1) != ((Numeric<decimal>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanMethod()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            bool expected = input1 < input2;

            bool actual = Numeric<decimal>.LessThan(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOperator()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            bool expected = input1 < input2;

            bool actual = ((Numeric<decimal>)input1) < ((Numeric<decimal>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanMethod()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            bool expected = input1 > input2;

            bool actual = Numeric<decimal>.GreaterThan(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOperator()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            bool expected = input1 > input2;

            bool actual = ((Numeric<decimal>)input1) > ((Numeric<decimal>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOrEqualMethod()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            bool expected = input1 <= input2;

            bool actual = Numeric<decimal>.LessThanOrEqual(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOrEqualOperator()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            bool expected = input1 <= input2;

            bool actual = ((Numeric<decimal>)input1) <= ((Numeric<decimal>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualMethod()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            bool expected = input1 >= input2;

            bool actual = Numeric<decimal>.GreaterThanOrEqual(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualOperator()
        {
            var rand = new Random();
            decimal input1 = rand.Next();
            decimal input2 = rand.Next();
            bool expected = input1 >= input2;

            bool actual = ((Numeric<decimal>)input1) >= ((Numeric<decimal>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetHashCodeMethodIsConsistent()
        {
            var rand = new Random();
            decimal input = (decimal)rand.Next();
            int expected = ((Numeric<decimal>)input).GetHashCode();

            int actual = ((Numeric<decimal>)input).GetHashCode();

            Assert.AreEqual(expected, actual);
        }
    }
}
