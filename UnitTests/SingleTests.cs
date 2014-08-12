using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeric;

namespace UnitTests
{
    [TestClass]
    public class SingleTests
    {
        [TestMethod]
        public void TestAddMethod()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            float expected = input1 + input2;

            float actual = Numeric<float>.Add(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddOperator()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            float expected = input1 + input2;

            float actual = ((Numeric<float>)input1) + ((Numeric<float>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractMethod()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            float expected = input1 - input2;

            float actual = Numeric<float>.Subtract(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractOperator()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            float expected = input1 - input2;

            float actual = ((Numeric<float>)input1) - ((Numeric<float>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyMethod()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            float expected = input1 * input2;

            float actual = Numeric<float>.Multiply(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyOperator()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            float expected = input1 * input2;

            float actual = ((Numeric<float>)input1) * ((Numeric<float>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivisionMethod()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            float expected = input1 / input2;

            float actual = Numeric<float>.Division(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivisionOperator()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            float expected = input1 / input2;

            float actual = ((Numeric<float>)input1) / ((Numeric<float>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUnaryNegationMethod()
        {
            var rand = new Random();
            float input = rand.Next();
            float expected = -input;

            float actual = Numeric<float>.UnaryNegation(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUnaryNegationOperator()
        {
            var rand = new Random();
            float input = rand.Next();
            float expected = -input;

            float actual = -((Numeric<float>)input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualsMethod()
        {
            var rand = new Random();
            float input1 = (float)rand.Next();
            float input2 = (float)rand.Next();
            bool expected = input1 == input2;

            bool actual = ((Numeric<float>)input1).Equals(input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualityMethod()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            bool expected = input1 == input2;

            bool actual = Numeric<float>.Equality(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualityOperator()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            bool expected = input1 == input2;

            bool actual = ((Numeric<float>)input1) == ((Numeric<float>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInequalityMethod()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            bool expected = input1 != input2;

            bool actual = Numeric<float>.Inequality(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInequalityOperator()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            bool expected = input1 != input2;

            bool actual = ((Numeric<float>)input1) != ((Numeric<float>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanMethod()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            bool expected = input1 < input2;

            bool actual = Numeric<float>.LessThan(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOperator()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            bool expected = input1 < input2;

            bool actual = ((Numeric<float>)input1) < ((Numeric<float>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanMethod()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            bool expected = input1 > input2;

            bool actual = Numeric<float>.GreaterThan(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOperator()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            bool expected = input1 > input2;

            bool actual = ((Numeric<float>)input1) > ((Numeric<float>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOrEqualMethod()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            bool expected = input1 <= input2;

            bool actual = Numeric<float>.LessThanOrEqual(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLessThanOrEqualOperator()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            bool expected = input1 <= input2;

            bool actual = ((Numeric<float>)input1) <= ((Numeric<float>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualMethod()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            bool expected = input1 >= input2;

            bool actual = Numeric<float>.GreaterThanOrEqual(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualOperator()
        {
            var rand = new Random();
            float input1 = rand.Next();
            float input2 = rand.Next();
            bool expected = input1 >= input2;

            bool actual = ((Numeric<float>)input1) >= ((Numeric<float>)input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetHashCodeMethodIsConsistent()
        {
            var rand = new Random();
            float input = (float)rand.Next();
            int expected = ((Numeric<float>)input).GetHashCode();

            int actual = ((Numeric<float>)input).GetHashCode();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMixedOperations()
        {
            var rand = new Random();
            float inputMin = 0.0f;
            float inputMax = 10.0f;
            float outputMin = 0.0f;
            float outputMax = 100.0f;
            float input = (float)rand.Next((int)inputMin, (int)inputMax);
            float expected = LerpMinMaxFloat(input, inputMin, inputMax, outputMin, outputMax);

            var actual = LerpMinMaxNumeric<float>(input, inputMin, inputMax, outputMin, outputMax);

            Assert.AreEqual(expected, actual);        
        }

        [ExcludeFromCodeCoverage]
        private static T LerpMinMaxNumeric<T>(Numeric<T> input, Numeric<T> inputMin, Numeric<T> inputMax, Numeric<T> outputMin, Numeric<T> outputMax)
        {
            if (input <= inputMin)
            {
                return outputMin;
            }
            else if (input >= inputMax)
            {
                return outputMax;
            }
            return outputMin + ((input - inputMin) / (inputMax - inputMin)) * (outputMax - outputMin);
        }

        [ExcludeFromCodeCoverage]
        private static float LerpMinMaxFloat(float input, float inputMin, float inputMax, float outputMin, float outputMax)
        {
            if (input <= inputMin)
            {
                return outputMin;
            }
            else if (input >= inputMax)
            {
                return outputMax;
            }
            return outputMin + ((input - inputMin) / (inputMax - inputMin)) * (outputMax - outputMin);
        }
    }
}
