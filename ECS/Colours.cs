using static ECS.MathC;

namespace ECS
{
    /// <summary>
    /// Colours class
    /// </summary>
    public static class Colours
    {
        /// <summary>
        /// Blue colour
        /// </summary>
        public static Colour Blue = new Colour(0, 0, 255);

        /// <summary>
        /// Green colour
        /// </summary>
        public static Colour Green = new Colour(0, 255, 0);

        /// <summary>
        /// Red colour
        /// </summary>
        public static Colour Red = new Colour(255, 0, 0);

        /// <summary>
        /// Black colour
        /// </summary>
        public static Colour Black = new Colour(0, 0, 0);

        /// <summary>
        /// White colour
        /// </summary>
        public static Colour White = new Colour(255, 255, 255);

        /// <summary>
        /// Gray colour
        /// </summary>
        public static Colour Gray = new Colour(125, 125, 125);

        /// <summary>
        /// Pink colour
        /// </summary>
        public static Colour Pink = new Colour(255, 192, 203);

        /// <summary>
        /// Lightpink colour
        /// </summary>
        public static Colour LightPink = new Colour(255, 182, 193);

        /// <summary>
        /// Hotpink colour
        /// </summary>
        public static Colour Hotpink = new Colour(255, 105, 180);
    }

    /// <summary>
    /// An RGB based colour
    /// </summary>
    public class Colour
    {
        /// <summary>
        /// Amount of red
        /// </summary>
        public int r;

        /// <summary>
        /// Amount of green
        /// </summary>
        public int g;

        /// <summary>
        /// amount of blue
        /// </summary>
        public int b;

        /// <summary>
        /// Alpha value of colour
        /// </summary>
        public int a = 255;

        /// <summary>
        /// Generate a new colour
        /// </summary>
        /// <param name="r">Amount of red in colour (0-255)</param>
        /// <param name="g">Amount of green in colour (0-255)</param>
        /// <param name="b">Amount of blue in colour (0-255)</param>
        public Colour(int r, int g, int b)
        {
            r = Clamp(r, 0, 255);
            g = Clamp(g, 0, 255);
            b = Clamp(b, 0, 255);

            this.r = r;
            this.g = g;
            this.b = b;
        }

        /// <summary>
        /// Generate a new colour with alpha
        /// </summary>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <param name="a"></param>
        public Colour(int r, int g, int b, int a) : this(r, g, b)
        {
            r = Clamp(r, 0, 255);
            g = Clamp(g, 0, 255);
            b = Clamp(b, 0, 255);
            a = Clamp(a, 0, 255);

            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }
    }
}
