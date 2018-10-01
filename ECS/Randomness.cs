using System;
using System.Collections.Generic;

namespace ECS
{
    /// <summary>
    /// Class of functions that make use of randomness
    /// </summary>
    public static class Randomness
    {
        private static Random prng = new Random();

        /// <summary>
        /// Return a random part of the array
        /// </summary>
        /// <typeparam name="T">Type of the array</typeparam>
        /// <param name="input">The input array</param>
        /// <returns>One random object in the array</returns>
        public static T Random<T>(T[] input)
        {
            return input[prng.Next(0, input.Length)];
        }

        /// <summary>
        /// Return a random part of the List
        /// </summary>
        /// <typeparam name="T">Type of the List</typeparam>
        /// <param name="input">The input List</param>
        /// <returns>One random object in the List</returns>
        public static T Random<T>(List<T> input)
        {
            return input[prng.Next(0, input.Count)];
        }

        /// <summary>
        /// Returns a random integer within a range
        /// </summary>
        /// <param name="low">Lower bound (inclusive)</param>
        /// <param name="hi">Higher bound (exclusive)</param>
        /// <returns></returns>
        public static int Random(int low, int hi)
        {
            return prng.Next(low, hi);
        }

        /// <summary>
        /// Returns a random double within a range
        /// </summary>
        /// <param name="low">Lower bound (inclusive)</param>
        /// <param name="hi">Higher bound (exclusive)</param>
        /// <returns></returns>
        public static double Random(double low, double hi)
        {
            return prng.NextDouble() * (hi - low) + hi;
        }

        /// <summary>
        /// Returns a random double within a range
        /// </summary>
        /// <param name="low">Lower bound (inclusive)</param>
        /// <param name="hi">Higher bound (exclusive)</param>
        /// <returns></returns>
        public static float Random(float low, float hi)
        {
            return (float)prng.NextDouble() * (hi - low) + hi;
        }

        /// <summary>
        /// Return a value between 0 and 1
        /// </summary>
        /// <returns></returns>
        public static double Random01()
        {
            return prng.NextDouble();
        }
    }
}