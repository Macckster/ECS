using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Vectors
{
    public class Vector3
    {
        public double x;
        public double y;
        public double z;

        public Vector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //Operations between two Vector3's

        public static Vector3 operator +(Vector3 a, Vector3 b) =>
            new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);

        public static Vector3 operator -(Vector3 a, Vector3 b) =>
            new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);

        //Operations between a Vector3 and a Vector2

        public static Vector3 operator +(Vector3 a, Vector2 b) =>
            new Vector3(a.x + b.x, a.y + b.y, a.z);

        public static Vector3 operator -(Vector3 a, Vector2 b) =>
            new Vector3(a.x - b.x, a.y - b.y, a.z);

        //Operations between a float and a Vector3

        public static Vector3 operator *(float a, Vector3 b) =>
            new Vector3(a * b.x, a * b.y, a * b.z);

        public static Vector3 operator *(Vector3 a, float b) =>
           new Vector3(a.x * b, a.y * b, a.z * b);

        public override string ToString() =>
            ($"x:{x} y:{y} z:{z}");


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

    public class Vector2
    {
        public double x;
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

        public static Vector2 operator +(Vector2 a, Vector2 b) =>
            new Vector2(a.x + b.x, a.y + b.y);

        public static Vector2 operator -(Vector2 a, Vector2 b) =>
            new Vector2(a.x - b.x, a.y - b.y);

        //Operations between a Vector2 and a Vector 3

        public static Vector3 operator +(Vector2 a, Vector3 b) =>
            new Vector3(a.x + b.x, a.y + b.y, b.z);

        public static Vector3 operator -(Vector2 a, Vector3 b) =>
            new Vector3(a.x - b.x, a.y - b.y, b.z);

        //Operations between a Vector2 and a float

        public static Vector2 operator *(float a, Vector2 b) =>
            new Vector2(a * b.x, a * b.y);

        public static Vector2 operator *(Vector2 a, float b) =>
           new Vector2(a.x * b, a.y * b);

        public override string ToString() =>
            ($"x:{x} y:{y}");

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