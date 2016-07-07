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

namespace Numeric
{
    /// <summary>
    /// Implements generic versions of common math operations
    /// </summary>
    /// <typeparam name="T">The underlying numeric type to perform calculations with.</typeparam>
    public static class Math<T>
    {
        /// <summary>
        /// Returns the absolute value of a numeric type.
        /// </summary>
        /// <param name="t">A positive or negative value of the numeric type</param>
        /// <returns>A value, x, such that 0 ≤ x.</returns>
        public static T Abs(T t)
        {
            if (Numeric<T>.GreaterThanOrEqual(t, Numeric<T>.Zero()))
                return t;
            else
                return Numeric<T>.UnaryNegation(t);

        }

        /// <summary>
        /// Returns a value clamped to a specified minimum and macimum
        /// </summary>
        /// <param name="t">The value to clamp</param>
        /// <param name="min">The inclusive minimum value to clamp to</param>
        /// <param name="max">The exclusive maximum value to clamp to</param>
        /// <returns>A value x, such that min <= x <= max</returns>
        public static T Clamp(T t, T min, T max)
        {
            if (Numeric<T>.LessThan(t, min))
                return min;
            if (Numeric<T>.GreaterThan(t, max))
                return max;
            else
                return t;
        }
    }
}
