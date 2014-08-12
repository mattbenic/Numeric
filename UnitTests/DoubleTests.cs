using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeric;

namespace UnitTests
{
    [TestClass]
    public class DoubleTests
    {
        [TestMethod]
        public void TestAddMethod()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            double expected = input1 + input2;

            double actual = Numeric<double>.Add(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddOperator()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            double expected = input1 + input2;

            double actual = ((Numeric<double>)input1) + ((Numeric<double>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractMethod()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            double expected = input1 - input2;

            double actual = Numeric<double>.Subtract(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractOperator()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            double expected = input1 - input2;

            double actual = ((Numeric<double>)input1) - ((Numeric<double>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyMethod()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            double expected = input1 * input2;

            double actual = Numeric<double>.Multiply(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyOperator()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            double expected = input1 * input2;

            double actual = ((Numeric<double>)input1) * ((Numeric<double>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivisionMethod()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            double expected = input1 / input2;

            double actual = Numeric<double>.Division(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivisionOperator()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            double expected = input1 / input2;

            double actual = ((Numeric<double>)input1) / ((Numeric<double>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUnaryNegationMethod()
        {
            var rand = new Random();
            double input = rand.Next();
            double expected = -input;

            double actual = Numeric<double>.UnaryNegation(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUnaryNegationOperator()
        {
            var rand = new Random();
            double input = rand.Next();
            double expected = -input;

            double actual = -((Numeric<double>)input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualsMethod()
        {
            var rand = new Random();
            double input1 = (double)rand.Next();
            double input2 = (double)rand.Next();
            bool expected = input1 == input2;

            bool actual = ((Numeric<double>)input1).Equals(input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualityMethod()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            bool expected = input1 == input2;

            bool actual = Numeric<double>.Equality(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualityOperator()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            bool expected = input1 == input2;

            bool actual = ((Numeric<double>)input1) == ((Numeric<double>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInequalityMethod()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            bool expected = input1 != input2;

            bool actual = Numeric<double>.Inequality(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInequalityOperator()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            bool expected = input1 != input2;

            bool actual = ((Numeric<double>)input1) != ((Numeric<double>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanMethod()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            bool expected = input1 < input2;

            bool actual = Numeric<double>.LessThan(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOperator()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            bool expected = input1 < input2;

            bool actual = ((Numeric<double>)input1) < ((Numeric<double>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanMethod()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            bool expected = input1 > input2;

            bool actual = Numeric<double>.GreaterThan(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOperator()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            bool expected = input1 > input2;

            bool actual = ((Numeric<double>)input1) > ((Numeric<double>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOrEqualMethod()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            bool expected = input1 <= input2;

            bool actual = Numeric<double>.LessThanOrEqual(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOrEqualOperator()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            bool expected = input1 <= input2;

            bool actual = ((Numeric<double>)input1) <= ((Numeric<double>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualMethod()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            bool expected = input1 >= input2;

            bool actual = Numeric<double>.GreaterThanOrEqual(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualOperator()
        {
            var rand = new Random();
            double input1 = rand.Next();
            double input2 = rand.Next();
            bool expected = input1 >= input2;

            bool actual = ((Numeric<double>)input1) >= ((Numeric<double>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetHashCodeMethodIsConsistent()
        {
            var rand = new Random();
            double input = (double)rand.Next();
            int expected = ((Numeric<double>)input).GetHashCode();

            int actual = ((Numeric<double>)input).GetHashCode();

            Assert.AreEqual(expected, actual);
        }
    }
}
