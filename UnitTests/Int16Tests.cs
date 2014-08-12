using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeric;

namespace UnitTests
{
    [TestClass]
    public class Int16Tests
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
    }
}
