﻿/*
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
    [ExcludeFromCodeCoverage]
    class Fake
    {
        public bool FakeCalled;

        public static Fake operator +(Fake fake1, Fake fake2)
        {
            fake1.FakeCalled = true;
            return fake1;
        }

        public static Fake operator -(Fake fake1, Fake fake2)
        {
            fake1.FakeCalled = true;
            return fake1;
        }

        public static Fake operator *(Fake fake1, Fake fake2)
        {
            fake1.FakeCalled = true;
            return fake1;
        }

        public static Fake operator /(Fake fake1, Fake fake2)
        {
            fake1.FakeCalled = true;
            return fake1;
        }

        public static Fake operator -(Fake fake1)
        {
            fake1.FakeCalled = true;
            return fake1;
        }

        public static bool operator ==(Fake fake1, Fake fake2)
        {
            fake1.FakeCalled = true;
            return false;
        }

        public static bool operator !=(Fake fake1, Fake fake2)
        {
            fake1.FakeCalled = true;
            return false;
        }

        public static bool operator >(Fake fake1, Fake fake2)
        {
            fake1.FakeCalled = true;
            return false;
        }

        public static bool operator <(Fake fake1, Fake fake2)
        {
            fake1.FakeCalled = true;
            return false;
        }

        public static bool operator >=(Fake fake1, Fake fake2)
        {
            fake1.FakeCalled = true;
            return false;
        }

        public static bool operator <=(Fake fake1, Fake fake2)
        {
            fake1.FakeCalled = true;
            return false;
        }

        public override bool Equals(object obj)
        {
            FakeCalled = true;
            return false;
        }

        public override int GetHashCode()
        {
            FakeCalled = true;
            return 0;
        }
    }

    [TestClass]
    public class FakeTest
    {
        [TestMethod]
        public void TestAddMethod()
        {
            var rand = new Random();
            var input1 = new Fake();
            var input2 = new Fake();

            var result = Numeric<Fake>.Add(input1, input2);

            Assert.IsTrue(result.FakeCalled);
        }

        [TestMethod]
        public void TestAddOperator()
        {
            var rand = new Random();
            var fake1 = new Fake();
            var fake2 = new Fake();

            var result = ((Numeric<Fake>)fake1) + ((Numeric<Fake>)fake2);

            Assert.IsTrue(fake1.FakeCalled);
        }

        [TestMethod]
        public void TestSubtractMethod()
        {
            var rand = new Random();
            var input1 = new Fake();
            var input2 = new Fake();

            var result = Numeric<Fake>.Subtract(input1, input2);

            Assert.IsTrue(result.FakeCalled);
        }

        [TestMethod]
        public void TestSubtractOperator()
        {
            var rand = new Random();
            var fake1 = new Fake();
            var fake2 = new Fake();

            var result = ((Numeric<Fake>)fake1) - ((Numeric<Fake>)fake2);

            Assert.IsTrue(fake1.FakeCalled);
        }

        [TestMethod]
        public void TestMultiplyMethod()
        {
            var rand = new Random();
            var input1 = new Fake();
            var input2 = new Fake();

            var result = Numeric<Fake>.Multiply(input1, input2);

            Assert.IsTrue(result.FakeCalled);
        }

        [TestMethod]
        public void TestMultiplyOperator()
        {
            var rand = new Random();
            var fake1 = new Fake();
            var fake2 = new Fake();

            var result = ((Numeric<Fake>)fake1) * ((Numeric<Fake>)fake2);

            Assert.IsTrue(fake1.FakeCalled);
        }

        [TestMethod]
        public void TestDivisionMethod()
        {
            var rand = new Random();
            var input1 = new Fake();
            var input2 = new Fake();

            var result = Numeric<Fake>.Division(input1, input2);

            Assert.IsTrue(result.FakeCalled);
        }

        [TestMethod]
        public void TestDivisionOperator()
        {
            var rand = new Random();
            var fake1 = new Fake();
            var fake2 = new Fake();

            var result = ((Numeric<Fake>)fake1) / ((Numeric<Fake>)fake2);

            Assert.IsTrue(fake1.FakeCalled);
        }

        [TestMethod]
        public void TestUnaryNegationMethod()
        {
            var rand = new Random();
            var input1 = new Fake();

            var result = Numeric<Fake>.UnaryNegation(input1);

            Assert.IsTrue(result.FakeCalled);
        }

        [TestMethod]
        public void TestUnaryNegationOperator()
        {
            var rand = new Random();
            var fake1 = new Fake();
            var fake2 = new Fake();

            var result = -((Numeric<Fake>)fake1);

            Assert.IsTrue(fake1.FakeCalled);
        }

        [TestMethod]
        public void TestEqualsMethod()
        {
            var rand = new Random();
            var input1 = new Fake();
            var input2 = new Fake();

            Numeric<Fake>.Equals(input1, input2);

            Assert.IsTrue(input1.FakeCalled);
        }

        [TestMethod]
        public void TestEqualityMethod()
        {
            var rand = new Random();
            var input1 = new Fake();
            var input2 = new Fake();

            Numeric<Fake>.Equality(input1, input2);

            Assert.IsTrue(input1.FakeCalled);
        }

        [TestMethod]
        public void TestEqualityOperator()
        {
            var rand = new Random();
            var fake1 = new Fake();
            var fake2 = new Fake();

            var result = ((Numeric<Fake>)fake1) == ((Numeric<Fake>)fake2);

            Assert.IsTrue(fake1.FakeCalled);
        }

        [TestMethod]
        public void TestInequalityMethod()
        {
            var rand = new Random();
            var input1 = new Fake();
            var input2 = new Fake();

            Numeric<Fake>.Inequality(input1, input2);

            Assert.IsTrue(input1.FakeCalled);
        }

        [TestMethod]
        public void TestInequalityOperator()
        {
            var rand = new Random();
            var fake1 = new Fake();
            var fake2 = new Fake();

            var result = ((Numeric<Fake>)fake1) != ((Numeric<Fake>)fake2);

            Assert.IsTrue(fake1.FakeCalled);
        }

        [TestMethod]
        public void TestLessThanMethod()
        {
            var rand = new Random();
            var input1 = new Fake();
            var input2 = new Fake();

            Numeric<Fake>.LessThan(input1, input2);

            Assert.IsTrue(input1.FakeCalled);
        }

        [TestMethod]
        public void TestLessThanOperator()
        {
            var rand = new Random();
            var fake1 = new Fake();
            var fake2 = new Fake();

            var result = ((Numeric<Fake>)fake1) < ((Numeric<Fake>)fake2);

            Assert.IsTrue(fake1.FakeCalled);
        }

        [TestMethod]
        public void TestGreaterThanMethod()
        {
            var rand = new Random();
            var input1 = new Fake();
            var input2 = new Fake();

            Numeric<Fake>.LessThan(input1, input2);

            Assert.IsTrue(input1.FakeCalled);
        }

        [TestMethod]
        public void TestGreaterThanOperator()
        {
            var rand = new Random();
            var fake1 = new Fake();
            var fake2 = new Fake();

            var result = ((Numeric<Fake>)fake1) > ((Numeric<Fake>)fake2);

            Assert.IsTrue(fake1.FakeCalled);
        }

        [TestMethod]
        public void TestLessThanOrEqualMethod()
        {
            var rand = new Random();
            var input1 = new Fake();
            var input2 = new Fake();

            Numeric<Fake>.LessThanOrEqual(input1, input2);

            Assert.IsTrue(input1.FakeCalled);
        }

        [TestMethod]
        public void TestLessThanOrEqualOperator()
        {
            var rand = new Random();
            var fake1 = new Fake();
            var fake2 = new Fake();

            var result = ((Numeric<Fake>)fake1) <= ((Numeric<Fake>)fake2);

            Assert.IsTrue(fake1.FakeCalled);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualMethod()
        {
            var rand = new Random();
            var input1 = new Fake();
            var input2 = new Fake();

            Numeric<Fake>.GreaterThanOrEqual(input1, input2);

            Assert.IsTrue(input1.FakeCalled);
        }

        [TestMethod]
        public void TestGreaterThanOrEqualOperator()
        {
            var rand = new Random();
            var fake1 = new Fake();
            var fake2 = new Fake();

            var result = ((Numeric<Fake>)fake1) >= ((Numeric<Fake>)fake2);

            Assert.IsTrue(fake1.FakeCalled);
        }
    }
}
