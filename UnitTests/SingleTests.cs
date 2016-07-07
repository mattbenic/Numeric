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
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeric;

namespace UnitTests
{
    [TestClass]
    public class SingleNumericTests
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
            float input1 = rand.Next();
            float input2 = rand.Next();
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
            float input = rand.Next();
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
            float input = rand.Next((int)inputMin, (int)inputMax);
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

        [TestMethod]
        public void TestToStringMethod()
        {
            var rand = new Random();
            float input = rand.Next();
            string expected = input.ToString();

            string actual = ((Numeric<float>)input).ToString();

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class SingleMathTests
    {
        [TestMethod]
        public void TestAbsMethodPositive()
        {
            var rand = new Random();
            float input = rand.Next(0, int.MaxValue);
            float expected = input;

            float actual = Math<float>.Abs(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAbsMethodNegative()
        {
            var rand = new Random();
            float input = rand.Next(int.MinValue, -1);
            float expected = -input;

            float actual = Math<float>.Abs(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClampMethodLessThan()
        {
            var rand = new Random();
            float min = rand.Next();
            float max = rand.Next((int)min, int.MaxValue);
            float input = rand.Next(int.MinValue, (int)min);
            float expected = min;

            float actual = Math<float>.Clamp(input, min, max);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClampMethodMoreThan()
        {
            var rand = new Random();
            float min = rand.Next();
            float max = rand.Next((int)min, int.MaxValue);
            float input = rand.Next((int)max, int.MaxValue);
            float expected = max;

            float actual = Math<float>.Clamp(input, min, max);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClampMethodInside()
        {
            var rand = new Random();
            float min = rand.Next();
            float max = rand.Next((int)min, int.MaxValue);
            float input = rand.Next((int)min, (int)max);
            float expected = input;

            float actual = Math<float>.Clamp(input, min, max);

            Assert.AreEqual(expected, actual);
        }
    }
}
