using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeric;

namespace UnitTests
{
    [TestClass]
    public class UInt32Tests
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
    }
}
