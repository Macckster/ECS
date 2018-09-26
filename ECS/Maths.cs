using System;

namespace ECS
{
    /// <summary>
    /// Math Class
    /// </summary>
    public static class Maths
    {
        /// <summary>
        /// Circle constant PI
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
        /// TAU (two times PI)
        /// </summary>
        public const double TAU = PI * 2;

        /// <summary>
        /// Eulers number
        /// </summary>
        public const double e = 2.71828182846;

        /// <summary>
        /// Convert degrees to radians (This is PI/180)
        /// </summary>
        public const double DEG2RAD = 0.0174532925;
        
        /// <summary>
        /// Get the square root of a number
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }

        /// <summary>
        /// Raise a number to a power
        /// </summary>
        /// <param name="a">Base</param>
        /// <param name="b">Exponent</param>
        /// <returns></returns>
        public static double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }
        
        /// <summary>
        /// Return e raised to a power
        /// </summary>
        /// <param name="a">Exponent</param>
        /// <returns></returns>
        public static double Exp(double a)
        {
            return Pow(e, a);
        }

        /// <summary>
        /// Calculate sin(a)
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Sin(double a)
        {
            return Math.Sin(a);
        }

        /// <summary>
        /// Calculate cos(a)
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Cos(double a)
        {
            return Math.Cos(a);
        }

        /// <summary>
        /// Calculate Tan(a)
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Tan(double a)
        {
            return Math.Tan(a);
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
        /// Map a number to a range
        /// </summary>
        /// <param name="n">Value you want to map</param>
        /// <param name="start1">Lower bound of the numbers range</param>
        /// <param name="stop1">Higher bound of the numbers range</param>
        /// <param name="start2">Lower bound of the outputs range</param>
        /// <param name="stop2">Higher bound of the outputs range</param>
        /// <returns>The number remapped to another range</returns>
        public static int Map(int n, int start1, int stop1, int start2, int stop2)
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
        public static int Clamp(int value, int lowerBound, int higherBound)
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
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int[,] MatrixMult(int[,] a, int[,] b)
        {
            int[,] ret = new int[a.GetLength(0), b.GetLength(1)];

            for (int i = 0; i < ret.GetLength(1); i++)
            {
                for (int j = 0; j < ret.GetLength(0); j++)
                {
                    int sum = 0;

                    for (int k = 0; k < a.GetLength(0); k++)
                    {
                        sum += a[i, k] * b[k, j];
                    }

                    ret[i, j] = sum;
                }
            }

            return ret;
        }

        /// <summary>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float[,] MatrixMult(float[,] a, float[,] b)
        {          
            float[,] ret = new float[a.GetLength(0),b.GetLength(1)];

            for (int i = 0; i < ret.GetLength(1); i++)
            {
                for (int j = 0; j < ret.GetLength(0); j++)
                {
                    float sum = 0;

                    for (int k = 0; k < a.GetLength(0); k++)
                    {
                        sum += a[i, k] * b[k, j];
                    }

                    ret[i, j] = sum;
                }
            }
            
            return ret;
        }

        /// <summary>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double[,] MatrixMult(double[,] a, double[,] b)
        {
            double[,] ret = new double[a.GetLength(0), b.GetLength(1)];

            for (int i = 0; i < ret.GetLength(1); i++)
            {
                for (int j = 0; j < ret.GetLength(0); j++)
                {
                    double sum = 0;

                    for (int k = 0; k < a.GetLength(0); k++)
                    {
                        sum += a[i, k] * b[k, j];
                    }

                    ret[i, j] = sum;
                }
            }

            return ret;
        }
        
        /// <summary>
        /// Print the values in a two dimensional array
        /// </summary>
        /// <param name="a">Array</param>
        public static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i, j]);
                }
            }
        }

        /// <summary>
        /// Print the values in a two dimensional array
        /// </summary>
        /// <param name="a">Array</param>
        public static void Print(float[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i, j]);
                }
            }
        }

        /// <summary>
        /// Print the values in a two dimensional array
        /// </summary>
        /// <param name="a">Array</param>
        public static void Print(double[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i, j]);
                }
            }
        }
    }
}