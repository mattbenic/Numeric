using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeric;

namespace UnitTests
{
    [TestClass]
    public class Int32Tests
    {
        [TestMethod]
        public void TestAddMethod()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            int expected = input1 + input2;

            int actual = Numeric<int>.Add(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddOperator()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            int expected = input1 + input2;

            int actual = ((Numeric<int>)input1) + ((Numeric<int>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractMethod()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            int expected = input1 - input2;

            int actual = Numeric<int>.Subtract(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractOperator()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            int expected = input1 - input2;

            int actual = ((Numeric<int>)input1) - ((Numeric<int>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyMethod()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            int expected = input1 * input2;

            int actual = Numeric<int>.Multiply(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyOperator()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            int expected = input1 * input2;

            int actual = ((Numeric<int>)input1) * ((Numeric<int>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivisionMethod()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            int expected = input1 / input2;

            int actual = Numeric<int>.Division(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivisionOperator()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            int expected = input1 / input2;

            int actual = ((Numeric<int>)input1) / ((Numeric<int>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUnaryNegationMethod()
        {
            var rand = new Random();
            int input = rand.Next();
            int expected = -input;

            int actual = Numeric<int>.UnaryNegation(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUnaryNegationOperator()
        {
            var rand = new Random();
            int input = rand.Next();
            int expected = -input;

            int actual = -((Numeric<int>)input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualsMethod()
        {
            var rand = new Random();
            int input1 = (int)rand.Next();
            int input2 = (int)rand.Next();
            bool expected = input1 == input2;

            bool actual = ((Numeric<int>)input1).Equals(input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualityMethod()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            bool expected = input1 == input2;

            bool actual = Numeric<int>.Equality(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualityOperator()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            bool expected = input1 == input2;

            bool actual = ((Numeric<int>)input1) == ((Numeric<int>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInequalityMethod()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            bool expected = input1 != input2;

            bool actual = Numeric<int>.Inequality(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInequalityOperator()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            bool expected = input1 != input2;

            bool actual = ((Numeric<int>)input1) != ((Numeric<int>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanMethod()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            bool expected = input1 < input2;

            bool actual = Numeric<int>.LessThan(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOperator()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            bool expected = input1 < input2;

            bool actual = ((Numeric<int>)input1) < ((Numeric<int>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanMethod()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            bool expected = input1 > input2;

            bool actual = Numeric<int>.GreaterThan(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOperator()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            bool expected = input1 > input2;

            bool actual = ((Numeric<int>)input1) > ((Numeric<int>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOrEqualMethod()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            bool expected = input1 <= input2;

            bool actual = Numeric<int>.LessThanOrEqual(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOrEqualOperator()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            bool expected = input1 <= input2;

            bool actual = ((Numeric<int>)input1) <= ((Numeric<int>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualMethod()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            bool expected = input1 >= input2;

            bool actual = Numeric<int>.GreaterThanOrEqual(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualOperator()
        {
            var rand = new Random();
            int input1 = rand.Next();
            int input2 = rand.Next();
            bool expected = input1 >= input2;

            bool actual = ((Numeric<int>)input1) >= ((Numeric<int>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetHashCodeMethodIsConsistent()
        {
            var rand = new Random();
            int input = (int)rand.Next();
            int expected = ((Numeric<int>)input).GetHashCode();

            int actual = ((Numeric<int>)input).GetHashCode();

            Assert.AreEqual(expected, actual);
        }
    }
}
