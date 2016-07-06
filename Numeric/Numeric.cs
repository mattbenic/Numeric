/*
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
using System.Collections.Generic;
using System.Reflection;

namespace Numeric
{
    /// <summary>
    /// Allows the creation of generic methods implementing numeric calculations.
    /// </summary>
    /// <remarks>
    /// Has MASSIVE performance drops over using basic types (1-2 orders of magnitude) due to stack allocations when implicitly casting. 
    /// Is equivalent in performance to MiscUtil's generic Operator class when used through operators, 
    /// and significantly faster when using methods directly.
    /// </remarks>
    /// <example>
    /// Example of use:
    /// <code>
    /// public static T LerpMinMax<T>(Numeric<T> input, Numeric<T> inputMin, Numeric<T> inputMax, Numeric<T> outputMin, Numeric<T> outputMax)
    /// {
    ///     if (input <= inputMin)
    ///     {
    ///        return outputMin;
    ///     }
    ///     else if (input >= inputMax)
    ///     {
    ///        return outputMax;
    ///     }
    ///
    ///     return outputMin + ((input - inputMin) / (inputMax - inputMin)) * (outputMax - outputMin);
    /// }
    /// </code>
    /// </example>
    /// <typeparam name="T">The underlying numeric type to perform calculations with.</typeparam>
    public struct Numeric<T>
    {
        public static readonly Func<T, T, T> Add;
        public static readonly Func<T, T, T> Subtract;
        public static readonly Func<T, T, T> Multiply;
        public static readonly Func<T, T, T> Division;
        public static readonly Func<T, T> UnaryNegation;
        public static readonly Func<T, T, bool> Equality;
        public static readonly Func<T, T, bool> Inequality;
        public static readonly Func<T, T, bool> LessThan;
        public static readonly Func<T, T, bool> GreaterThan;
        public static readonly Func<T, T, bool> LessThanOrEqual;
        public static readonly Func<T, T, bool> GreaterThanOrEqual;

        private T value;

        static Numeric()
        {
            Add = OperatorProvider.Add<T>() as Func<T, T, T>;
            Subtract = OperatorProvider.Subtract<T>() as Func<T, T, T>;
            Multiply = OperatorProvider.Multiply<T>() as Func<T, T, T>;
            Division = OperatorProvider.Division<T>() as Func<T, T, T>;
            UnaryNegation = OperatorProvider.UnaryNegation<T>() as Func<T, T>;
            Equality = OperatorProvider.Equality<T>() as Func<T, T, bool>;
            Inequality = OperatorProvider.Inequality<T>() as Func<T, T, bool>;
            LessThan = OperatorProvider.LessThan<T>() as Func<T, T, bool>;
            GreaterThan = OperatorProvider.GreaterThan<T>() as Func<T, T, bool>;
            LessThanOrEqual = OperatorProvider.LessThanOrEqual<T>() as Func<T, T, bool>;
            GreaterThanOrEqual = OperatorProvider.GreaterThanOrEqual<T>() as Func<T, T, bool>;
        }

        #region Conversion operators
        /// <summary>
        /// Implicit conversion operator to underlying type
        /// </summary>
        /// <param name="num">A Numeric object to get the T value of</param>
        /// <returns>The T equivalent of num</returns>
        public static implicit operator T(Numeric<T> num)
        {
            return num.value;
        }

        /// <summary>
        /// Implicit conversion operator from underlying type
        /// </summary>
        /// <param name="t">T to get a Numeric equivalent of</param>
        /// <returns>A Numeric corresponding to t</returns>
        public static implicit operator Numeric<T>(T t)
        {
            return new Numeric<T>() { value = t };
        }
        #endregion

        #region Numeric operators
        public static Numeric<T> operator +(Numeric<T> num1, Numeric<T> num2)
        {
            return Add(num1, num2);
        }

        public static Numeric<T> operator -(Numeric<T> num1, Numeric<T> num2)
        {
            return Subtract(num1, num2);
        }

        public static Numeric<T> operator *(Numeric<T> num1, Numeric<T> num2)
        {
            return Multiply(num1, num2);
        }

        public static Numeric<T> operator /(Numeric<T> num1, Numeric<T> num2)
        {
            return Division(num1, num2);
        }

        public static Numeric<T> operator -(Numeric<T> num)
        {
            return UnaryNegation(num);
        }

        public static bool operator ==(Numeric<T> num1, Numeric<T> num2)
        {
            return Equality(num1, num2);
        }

        public static bool operator !=(Numeric<T> num1, Numeric<T> num2)
        {
            return Inequality(num1, num2);
        }

        public static bool operator >(Numeric<T> num1, Numeric<T> num2)
        {
            return GreaterThan(num1, num2);
        }

        public static bool operator <(Numeric<T> num1, Numeric<T> num2)
        {
            return LessThan(num1, num2);
        }

        public static bool operator >=(Numeric<T> num1, Numeric<T> num2)
        {
            return GreaterThanOrEqual(num1, num2);
        }

        public static bool operator <=(Numeric<T> num1, Numeric<T> num2)
        {
            return LessThanOrEqual(num1, num2);
        }
        #endregion

        #region Object overrides
        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            return value.Equals(obj);
        }

        /// <summary>
        /// Provides a hash for the current object.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return value.GetHashCode();
        }
        #endregion
    }

    /// <summary>
    /// Helper class to separate out provision of concrete method implementations
    /// from the Numeric class
    /// </summary>
    internal class OperatorProvider
    {
        /// <summary>
        /// Returns an Add method for the type T cast as an object
        /// </summary>
        /// <typeparam name="T">Type to get the method for</typeparam>
        /// <returns>A method that uses the Type T's native + operator if possible, or it's op_Addition otherwise</returns>
        public static object Add<T>()
        {
            switch (typeof(T).Name)
            {
                case "UInt64":
                    return (Func<ulong, ulong, ulong>)((ulong a, ulong b) => a + b);
                case "Int64":
                    return (Func<long, long, long>)((long a, long b) => a + b);
                case "UInt32":
                    return (Func<uint, uint, uint>)((uint a, uint b) => a + b);
                case "Double":
                    return (Func<double, double, double>)((double a, double b) => a + b);
                case "Decimal":
                    return (Func<decimal, decimal, decimal>)((decimal a, decimal b) => a + b);
                case "Int32":
                    return (Func<int, int, int>)((int a, int b) => a + b);
                case "Single":
                    return (Func<float, float, float>)((float a, float b) => a + b);
                default:
                    return GetNamedBinaryOperator<T, T>("op_Addition");
            }
        }

        /// <summary>
        /// Returns a Subtract method for the type T cast as an object
        /// </summary>
        /// <typeparam name="T">Type to get the method for</typeparam>
        /// <returns>A method that uses the Type T's native - operator if possible, or it's op_Subtraction otherwise</returns>
        public static object Subtract<T>()
        {
            switch (typeof(T).Name)
            {
                case "UInt64":
                    return (Func<ulong, ulong, ulong>)((ulong a, ulong b) => a - b);
                case "Int64":
                    return (Func<long, long, long>)((long a, long b) => a - b);
                case "UInt32":
                    return (Func<uint, uint, uint>)((uint a, uint b) => a - b);
                case "Double":
                    return (Func<double, double, double>)((double a, double b) => a - b);
                case "Decimal":
                    return (Func<decimal, decimal, decimal>)((decimal a, decimal b) => a - b);
                case "Int32":
                    return (Func<int, int, int>)((int a, int b) => a - b);
                case "Single":
                    return (Func<float, float, float>)((float a, float b) => a - b);
                default:
                    return GetNamedBinaryOperator<T, T>("op_Subtraction");
            }
        }

        /// <summary>
        /// Returns a Multiply method for the type T cast as an object
        /// </summary>
        /// <typeparam name="T">Type to get the method for</typeparam>
        /// <returns>A method that uses the Type T's native * operator if possible, or it's op_Multiply otherwise</returns>
        public static object Multiply<T>()
        {
            switch (typeof(T).Name)
            {
                case "UInt64":
                    return (Func<ulong, ulong, ulong>)((ulong a, ulong b) => a * b);
                case "Int64":
                    return (Func<long, long, long>)((long a, long b) => a * b);
                case "UInt32":
                    return (Func<uint, uint, uint>)((uint a, uint b) => a * b);
                case "Double":
                    return (Func<double, double, double>)((double a, double b) => a * b);
                case "Decimal":
                    return (Func<decimal, decimal, decimal>)((decimal a, decimal b) => a * b);
                case "Int32":
                    return (Func<int, int, int>)((int a, int b) => a * b);
                case "Single":
                    return (Func<float, float, float>)((float a, float b) => a * b);
                default:
                    return GetNamedBinaryOperator<T, T>("op_Multiply");
            }
        }

        /// <summary>
        /// Returns a Division method for the type T cast as an object
        /// </summary>
        /// <typeparam name="T">Type to get the method for</typeparam>
        /// <returns>A method that uses the Type T's native / operator if possible, or it's op_Division otherwise</returns>
        public static object Division<T>()
        {
            switch (typeof(T).Name)
            {
                case "UInt64":
                    return (Func<ulong, ulong, ulong>)((ulong a, ulong b) => a / b);
                case "Int64":
                    return (Func<long, long, long>)((long a, long b) => a / b);
                case "UInt32":
                    return (Func<uint, uint, uint>)((uint a, uint b) => a / b);
                case "Double":
                    return (Func<double, double, double>)((double a, double b) => a / b);
                case "Decimal":
                    return (Func<decimal, decimal, decimal>)((decimal a, decimal b) => a / b);
                case "Int32":
                    return (Func<int, int, int>)((int a, int b) => a / b);
                case "Single":
                    return (Func<float, float, float>)((float a, float b) => a / b);
                default:
                    return GetNamedBinaryOperator<T, T>("op_Division");
            }
        }

        /// <summary>
        /// Returns a UnaryNegation method for the type T cast as an object
        /// </summary>
        /// <typeparam name="T">Type to get the method for</typeparam>
        /// <returns>A method that uses the Type T's native unary - operator if possible, or it's op_UnaryNegation otherwise</returns>
        public static object UnaryNegation<T>()
        {
            switch (typeof(T).Name)
            {
                case "Int64":
                    return (Func<long, long>)((long a) => -a);
                case "Double":
                    return (Func<double, double>)((double a) => -a);
                case "Decimal":
                    return (Func<decimal, decimal>)((decimal a) => -a);
                case "Int32":
                    return (Func<int, int>)((int a) => -a);
                case "Single":
                    return (Func<float, float>)((float a) => -a);
                default:
                    return GetNamedUnaryOperator<T>("op_UnaryNegation");
            }
        }

        /// <summary>
        /// Returns a Equality method for the type T cast as an object
        /// </summary>
        /// <typeparam name="T">Type to get the method for</typeparam>
        /// <returns>A method that uses the Type T's native == operator if possible, or it's op_Equality otherwise</returns>
        public static object Equality<T>()
        {
            switch (typeof(T).Name)
            {
                case "UInt16":
                    return (Func<ushort, ushort, bool>)((ushort a, ushort b) => a == b);
                case "Int16":
                    return (Func<short, short, bool>)((short a, short b) => a == b);
                case "UInt64":
                    return (Func<ulong, ulong, bool>)((ulong a, ulong b) => a == b);
                case "Int64":
                    return (Func<long, long, bool>)((long a, long b) => a == b);
                case "UInt32":
                    return (Func<uint, uint, bool>)((uint a, uint b) => a == b);
                case "Double":
                    return (Func<double, double, bool>)((double a, double b) => a == b);
                case "Decimal":
                    return (Func<decimal, decimal, bool>)((decimal a, decimal b) => a == b);
                case "Int32":
                    return (Func<int, int, bool>)((int a, int b) => a == b);
                case "Single":
                    return (Func<float, float, bool>)((float a, float b) => a == b);
                default:
                    return GetNamedBinaryOperator<T, bool>("op_Equality");
            }
        }

        /// <summary>
        /// Returns a Inequality method for the type T cast as an object
        /// </summary>
        /// <typeparam name="T">Type to get the method for</typeparam>
        /// <returns>A method that uses the Type T's native != operator if possible, or it's op_Inequality otherwise</returns>
        public static object Inequality<T>()
        {
            switch (typeof(T).Name)
            {
                case "UInt16":
                    return (Func<ushort, ushort, bool>)((ushort a, ushort b) => a != b);
                case "Int16":
                    return (Func<short, short, bool>)((short a, short b) => a != b);
                case "UInt64":
                    return (Func<ulong, ulong, bool>)((ulong a, ulong b) => a != b);
                case "Int64":
                    return (Func<long, long, bool>)((long a, long b) => a != b);
                case "UInt32":
                    return (Func<uint, uint, bool>)((uint a, uint b) => a != b);
                case "Double":
                    return (Func<double, double, bool>)((double a, double b) => a != b);
                case "Decimal":
                    return (Func<decimal, decimal, bool>)((decimal a, decimal b) => a != b);
                case "Int32":
                    return (Func<int, int, bool>)((int a, int b) => a != b);
                case "Single":
                    return (Func<float, float, bool>)((float a, float b) => a != b);
                default:
                    return GetNamedBinaryOperator<T, bool>("op_Inequality");
            }
        }

        /// <summary>
        /// Returns a LessThan method for the type T cast as an object
        /// </summary>
        /// <typeparam name="T">Type to get the method for</typeparam>
        /// <returns>A method that uses the Type T's native < operator if possible, or it's op_LessThan otherwise</returns>
        public static object LessThan<T>()
        {
            switch (typeof(T).Name)
            {
                case "UInt16":
                    return (Func<ushort, ushort, bool>)((ushort a, ushort b) => a < b);
                case "Int16":
                    return (Func<short, short, bool>)((short a, short b) => a < b);
                case "UInt64":
                    return (Func<ulong, ulong, bool>)((ulong a, ulong b) => a < b);
                case "Int64":
                    return (Func<long, long, bool>)((long a, long b) => a < b);
                case "UInt32":
                    return (Func<uint, uint, bool>)((uint a, uint b) => a < b);
                case "Double":
                    return (Func<double, double, bool>)((double a, double b) => a < b);
                case "Decimal":
                    return (Func<decimal, decimal, bool>)((decimal a, decimal b) => a < b);
                case "Int32":
                    return (Func<int, int, bool>)((int a, int b) => a < b);
                case "Single":
                    return (Func<float, float, bool>)((float a, float b) => a < b);
                default:
                    return GetNamedBinaryOperator<T, bool>("op_LessThan");
            }
        }

        /// <summary>
        /// Returns a GreaterThan method for the type T cast as an object
        /// </summary>
        /// <typeparam name="T">Type to get the method for</typeparam>
        /// <returns>A method that uses the Type T's native > operator if possible, or it's op_GreaterThan otherwise</returns>
        public static object GreaterThan<T>()
        {
            switch (typeof(T).Name)
            {
                case "UInt16":
                    return (Func<ushort, ushort, bool>)((ushort a, ushort b) => a > b);
                case "Int16":
                    return (Func<short, short, bool>)((short a, short b) => a > b);
                case "UInt64":
                    return (Func<ulong, ulong, bool>)((ulong a, ulong b) => a > b);
                case "Int64":
                    return (Func<long, long, bool>)((long a, long b) => a > b);
                case "UInt32":
                    return (Func<uint, uint, bool>)((uint a, uint b) => a > b);
                case "Double":
                    return (Func<double, double, bool>)((double a, double b) => a > b);
                case "Decimal":
                    return (Func<decimal, decimal, bool>)((decimal a, decimal b) => a > b);
                case "Int32":
                    return (Func<int, int, bool>)((int a, int b) => a > b);
                case "Single":
                    return (Func<float, float, bool>)((float a, float b) => a > b);
                default:
                    return GetNamedBinaryOperator<T, bool>("op_GreaterThan");
            }
        }

        /// <summary>
        /// Returns a LessThanOrEqual method for the type T cast as an object
        /// </summary>
        /// <typeparam name="T">Type to get the method for</typeparam>
        /// <returns>A method that uses the Type T's native <= operator if possible, or it's op_LessThanOrEqual otherwise</returns>
        public static object LessThanOrEqual<T>()
        {
            switch (typeof(T).Name)
            {
                case "UInt16":
                    return (Func<ushort, ushort, bool>)((ushort a, ushort b) => a <= b);
                case "Int16":
                    return (Func<short, short, bool>)((short a, short b) => a <= b);
                case "UInt64":
                    return (Func<ulong, ulong, bool>)((ulong a, ulong b) => a <= b);
                case "Int64":
                    return (Func<long, long, bool>)((long a, long b) => a <= b);
                case "UInt32":
                    return (Func<uint, uint, bool>)((uint a, uint b) => a <= b);
                case "Double":
                    return (Func<double, double, bool>)((double a, double b) => a <= b);
                case "Decimal":
                    return (Func<decimal, decimal, bool>)((decimal a, decimal b) => a <= b);
                case "Int32":
                    return (Func<int, int, bool>)((int a, int b) => a <= b);
                case "Single":
                    return (Func<float, float, bool>)((float a, float b) => a <= b);
                default:
                    return GetNamedBinaryOperator<T, bool>("op_LessThanOrEqual");
            }
        }

        /// <summary>
        /// Returns a GreaterThanOrEqual method for the type T cast as an object
        /// </summary>
        /// <typeparam name="T">Type to get the method for</typeparam>
        /// <returns>A method that uses the Type T's native >= operator if possible, or it's op_GreaterThanOrEqual otherwise</returns>
        public static object GreaterThanOrEqual<T>()
        {
            switch (typeof(T).Name)
            {
                case "UInt16":
                    return (Func<ushort, ushort, bool>)((ushort a, ushort b) => a >= b);
                case "Int16":
                    return (Func<short, short, bool>)((short a, short b) => a >= b);
                case "UInt64":
                    return (Func<ulong, ulong, bool>)((ulong a, ulong b) => a >= b);
                case "Int64":
                    return (Func<long, long, bool>)((long a, long b) => a >= b);
                case "UInt32":
                    return (Func<uint, uint, bool>)((uint a, uint b) => a >= b);
                case "Double":
                    return (Func<double, double, bool>)((double a, double b) => a >= b);
                case "Decimal":
                    return (Func<decimal, decimal, bool>)((decimal a, decimal b) => a >= b);
                case "Int32":
                    return (Func<int, int, bool>)((int a, int b) => a >= b);
                case "Single":
                    return (Func<float, float, bool>)((float a, float b) => a >= b);
                default:
                    return GetNamedBinaryOperator<T, bool>("op_GreaterThanOrEqual");
            }
        }

        /// <summary>
        /// Gets a method that invokes the specified binary operator from T's type
        /// </summary>
        /// <typeparam name="T">Binary operator parameter type</typeparam>
        /// <typeparam name="R">Binary operator return type</typeparam>
        /// <returns>A method that invokes the specified binary operator if it was found, null otherwise</returns>
        private static Func<T, T, R> GetNamedBinaryOperator<T, R>(string name)
        {
            BindingFlags bindingAttr = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
            Type type = typeof(T);
            var paramTypes = new Type[] { type, type };
            var methodInfo = typeof(T).GetMethod(name, bindingAttr, null, paramTypes, null);
            if (null == methodInfo)
            {
                return (T t1, T t2) => { throw new NoSuchOperationException<T>(name); };
            }
            return (T t1, T t2) => { return (R)methodInfo.Invoke(null, new object[] { t1, t2 }); };
        }

        /// <summary>
        /// Gets a method that invokes the specified unary operator from T's type
        /// </summary>
        /// <typeparam name="T">Unary operator parameter and return type</typeparam>
        /// <returns>A method that invokes the specified unary operator if it was found, null otherwise</returns>
        private static Func<T, T> GetNamedUnaryOperator<T>(string name)
        {
            BindingFlags bindingAttr = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
            Type type = typeof(T);
            var paramTypes = new Type[] { type };
            var methodInfo = typeof(T).GetMethod(name, bindingAttr, null, paramTypes, null);
            if (null == methodInfo)
            {
                return (T t) => { throw new NoSuchOperationException<T>(name); };
            }
            return (T t) => { return (T)methodInfo.Invoke(null, new object[] { t }); };
        }
    }

    /// <summary>
    /// An exception thrown when a requested operation does not exist
    /// </summary>
    public sealed class NoSuchOperationException<T> : Exception
    {
        public NoSuchOperationException(string operationName) : 
            base(string.Format("{0} does not have a {1} operation", typeof(T), operationName)) { }
    }
}
