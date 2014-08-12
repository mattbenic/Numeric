using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeric;

namespace UnitTests
{
    [TestClass]
    public class UInt16Tests
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
    }
}
