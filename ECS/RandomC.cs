using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS
{
    public static class RandomC
    {
        private static System.Random prng = new System.Random();

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
    }
}
