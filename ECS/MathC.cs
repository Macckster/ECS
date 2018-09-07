using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS
{
    /// <summary>
    /// Math Class
    /// </summary>
    public static class MathC
    {
        /// <summary>
        /// PI
        /// </summary>
        public const double PI = 3.14159265359;

        /// <summary>
        /// PI/2
        /// </summary>
        public const double HALF_PI = PI / 2;

        /// <summary>
        /// PI/4
        /// </summary>
        public const double QUARTER_PI = PI / 4;

        /// <summary>
        /// TAU
        /// </summary>
        public const double TAU = PI * 2;

        /// <summary>
        /// Eulers number
        /// </summary>
        public const double E = 2.71828182846;

        /// <summary>
        /// Convert degrees to radians
        /// </summary>
        public const double DEG2RAD = 0.0174532925;

        /// <summary>
        /// Map a number to a range
        /// </summary>
        /// <param name="n">Value you want to map</param>
        /// <param name="start1">Lower bound of the numbers range</param>
        /// <param name="stop1">Higher bound of the numbers range</param>
        /// <param name="start2">Lower bound of the outputs range</param>
        /// <param name="stop2">Higher bound of the outputs range</param>
        /// <returns>The number remapped to another range</returns>
        public static float Map(float n, float start1, float stop1, float start2, float stop2)
        {
            return (n - start1) / (stop1 - start1) * (stop2 - start2) + start2;
        }

        /// <summary>
        /// Map a number to a range
        /// </summary>
        /// <param name="n">Value you want to map</param>
        /// <param name="start1">Lower bound of the numbers range</param>
        /// <param name="stop1">Higher bound of the numbers range</param>
        /// <param name="start2">Lower bound of the outputs range</param>
        /// <param name="stop2">Higher bound of the outputs range</param>
        /// <returns>The number remapped to another range</returns>
        public static double Map(double n, double start1, double stop1, double start2, double stop2)
        {
            return (n - start1) / (stop1 - start1) * (stop2 - start2) + start2;
        }

        /// <summary>
        /// Clamp a number between to values
        /// </summary>
        /// <param name="value">The value to be clamped</param>
        /// <param name="lowerBound">Lowest acceptable value</param>
        /// <param name="higherBound">Highest acceptable value</param>
        /// <returns></returns>
        public static float Clamp(float value, float lowerBound, float higherBound)
        {
            if (value <= lowerBound)
                return lowerBound;
            if (value >= higherBound)
                return higherBound;

            return value;
        }

        /// <summary>
        /// Clamp a number between to values
        /// </summary>
        /// <param name="value">The value to be clamped</param>
        /// <param name="lowerBound">Lowest acceptable value</param>
        /// <param name="higherBound">Highest acceptable value</param>
        /// <returns></returns>
        public static double Clamp(double value, double lowerBound, double higherBound)
        {
            if (value <= lowerBound)
                return lowerBound;
            if (value >= higherBound)
                return higherBound;

            return value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float[,] MatrixMult(float[,] a, float[,] b)
        {          
            float[,] ret = new float[a.GetLength(0),b.GetLength(1)];

            return ret;
        }
    }
}
