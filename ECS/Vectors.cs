using System;

namespace ECS.Vectors
{
    /// <summary>
    /// 3 dimensional vector class
    /// </summary>
    public class Vector3
    {
        /// <summary>
        /// X component
        /// </summary>
        public double x;

        /// <summary>
        /// Y component
        /// </summary>
        public double y;

        /// <summary>
        /// z component
        /// </summary>
        public double z;

        /// <summary>
        /// Create a new vector3
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Vector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //Operations between two Vector3's

        /// <summary>
        /// Add two vector3's
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector3 operator +(Vector3 a, Vector3 b) =>
            new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);


        /// <summary>
        /// Subtract two vector3's
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector3 operator -(Vector3 a, Vector3 b) =>
            new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);

        //Operations between a Vector3 and a Vector2

        /// <summary>
        /// Add a vector2 to a vector3
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector3 operator +(Vector3 a, Vector2 b) =>
            new Vector3(a.x + b.x, a.y + b.y, a.z);

        /// <summary>
        /// Subtract a vector2 from a vector3
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector3 operator -(Vector3 a, Vector2 b) =>
            new Vector3(a.x - b.x, a.y - b.y, a.z);

        //Operations between a float and a Vector3

        /// <summary>
        /// Scale a vector3 with a float
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector3 operator *(float a, Vector3 b) =>
            new Vector3(a * b.x, a * b.y, a * b.z);

        /// <summary>
        /// Scale a vector3 with a float
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector3 operator *(Vector3 a, float b) =>
           new Vector3(a.x * b, a.y * b, a.z * b);

        /// <summary>
        /// Convert a vector3 to a string
        /// </summary>
        /// <returns></returns>
        public override string ToString() =>
            ($"{x}, {y}, {z}");


        /// <summary>
        /// Linerarly interpolate between two vectors given a percent of the way there
        /// </summary>
        /// <param name="a">Start</param>
        /// <param name="b">End</param>
        /// <param name="percent">How close we are</param>
        /// <returns></returns>
        public static Vector3 Lerp(Vector3 a, Vector3 b, float percent)
        {
            return (a + percent * (a - b));
        }


        /// <summary>
        /// Get the length of the Vector
        /// </summary>
        /// <returns>
        /// Vector length
        /// </returns>
        public double SqrDist()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }
    }

    /// <summary>
    /// 2 dimensional vector class
    /// </summary>
    public class Vector2
    {
        /// <summary>
        /// X component
        /// </summary>
        public double x;

        /// <summary>
        /// y component
        /// </summary>
        public double y;

        /// <summary>
        /// Create a new 2 dimensional vector
        /// </summary>
        /// <param name="x">X Component</param>
        /// <param name="y">Y Component</param>
        public Vector2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Create a new 2 dimensional vector
        /// </summary>
        public Vector2(){}

        //Operations between two Vectors2's


        /// <summary>
        /// add two vector2's
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector2 operator +(Vector2 a, Vector2 b) =>
            new Vector2(a.x + b.x, a.y + b.y);


        /// <summary>
        /// Subtract two vector2's
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector2 operator -(Vector2 a, Vector2 b) =>
            new Vector2(a.x - b.x, a.y - b.y);

        //Operations between a Vector2 and a Vector 3

        /// <summary>
        /// Add a vector 2 to a vector 3
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector3 operator +(Vector2 a, Vector3 b) =>
            new Vector3(a.x + b.x, a.y + b.y, b.z);

        /// <summary>
        /// subtract a vector2 from a vector3
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector3 operator -(Vector2 a, Vector3 b) =>
            new Vector3(a.x - b.x, a.y - b.y, b.z);

        //Operations between a Vector2 and a float

        /// <summary>
        /// Scale a vector2 with a float
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector2 operator *(float a, Vector2 b) =>
            new Vector2(a * b.x, a * b.y);

        /// <summary>
        /// Scale a vector2 with a float
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector2 operator *(Vector2 a, float b) =>
           new Vector2(a.x * b, a.y * b);

        /// <summary>
        /// Convert a vector2 to a string
        /// </summary>
        /// <returns></returns>
        public override string ToString() =>
            ($"{x}, {y}");

        /// <summary>
        /// Linerarly interpolate between two vectors give a percent of the way there
        /// </summary>
        /// <param name="a">Start</param>
        /// <param name="b">End</param>
        /// <param name="percent">How close we are</param>
        /// <returns></returns>
        public static Vector2 Lerp(Vector2 a, Vector2 b, float percent)
        {
            return (a + percent * (a - b));
        }


        /// <summary>
        /// Get the length of the Vector
        /// </summary>
        /// <returns>
        /// Vector length
        /// </returns>
        public double SqrDist()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }
}