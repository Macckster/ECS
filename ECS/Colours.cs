﻿using static ECS.Maths;

namespace ECS
{
    /// <summary>
    /// Colours class
    /// </summary>
    public static class Colours
    {
        #region Pre-Defined Colours
        /// <summary>
        /// Yellow Colour
        /// </summary>
        public readonly static Colour Yellow = new Colour(255, 255, 0);

        /// <summary>
        /// Lemon yellow Colour
        /// </summary>
        public readonly static Colour LemonYellow = new Colour(255, 255, 224);

        /// <summary>
        /// Gold Colour
        /// </summary>
        public readonly static Colour Gold = new Colour(255, 215, 0);

        /// <summary>
        /// Orange Colour
        /// </summary>
        public readonly static Colour Orange = new Colour(255, 165, 0);

        /// <summary>
        /// Dark orange Colour
        /// </summary>
        public readonly static Colour DarkOrange = new Colour(100, 55, 0);

        /// <summary>
        /// Blue colour
        /// </summary>
        public readonly static Colour Blue = new Colour(0, 0, 255);

        /// <summary>
        /// Royal blue colour
        /// </summary>
        public readonly static Colour RoyalBlue = new Colour(17, 30, 108);

        /// <summary>
        /// Navy blue colour
        /// </summary>
        public readonly static Colour NavyBlue = new Colour(0, 0, 128);

        /// <summary>
        /// Azure blue colour
        /// </summary>
        public readonly static Colour AzureBlue = new Colour(0, 128, 255);

        /// <summary>
        /// Space blue colour
        /// </summary>
        public readonly static Colour SpaceBlue = new Colour(29, 41, 81);

        /// <summary>
        /// Turquoise blue
        /// </summary>
        public readonly static Colour TurquoiseBlue = new Colour(63, 224, 208);

        /// <summary>
        /// Green colour
        /// </summary>
        public readonly static Colour Green = new Colour(0, 255, 0);

        /// <summary>
        /// Forest green colour
        /// </summary>
        public readonly static Colour ForestGreen = new Colour(11, 102, 35);

        /// <summary>
        /// Army green colour
        /// </summary>
        public readonly static Colour ArmyGreen = new Colour(75, 83, 32);

        /// <summary>
        /// Uniform green colour
        /// </summary>
        public readonly static Colour UniformGreen = new Colour(68, 76, 56);

        /// <summary>
        /// Emerald green Colour
        /// </summary>
        public readonly static Colour EmeraldGreen = new Colour(80, 220, 100);

        /// <summary>
        /// Lime green colour
        /// </summary>
        public readonly static Colour LimeGreen = new Colour(199, 234, 70);

        /// <summary>
        /// Olive green colour
        /// </summary>
        public readonly static Colour OliveGreen = new Colour(112, 130, 56);

        /// <summary>
        /// Sacramento green colour
        /// </summary>
        public readonly static Colour SacramentoGreen = new Colour(11, 102, 35);

        /// <summary>
        /// Mint green colour
        /// </summary>
        public readonly static Colour MintGreen = new Colour(0, 78, 56);

        /// <summary>
        /// Red colour
        /// </summary>
        public readonly static Colour Red = new Colour(255, 0, 0);

        /// <summary>
        /// Black colour
        /// </summary>
        public readonly static Colour Black = new Colour(0, 0, 0);

        /// <summary>
        /// White colour
        /// </summary>
        public readonly static Colour White = new Colour(255, 255, 255);

        /// <summary>
        /// Beige colour
        /// </summary>
        public readonly static Colour Beige = new Colour(245, 245, 220);

        /// <summary>
        /// Gray colour
        /// </summary>
        public readonly static Colour Gray = new Colour(125, 125, 125);

        /// <summary>
        /// Pink colour
        /// </summary>
        public readonly static Colour Pink = new Colour(255, 192, 203);

        /// <summary>
        /// Lightpink colour
        /// </summary>
        public readonly static Colour LightPink = new Colour(255, 182, 193);

        /// <summary>
        /// Hotpink colour
        /// </summary>
        public readonly static Colour Hotpink = new Colour(255, 105, 180);

        #endregion

        /// <summary>
        /// Linearly interpolate between two colours
        /// </summary>
        /// <param name="a">First colour</param>
        /// <param name="b">Second colour</param>
        /// <param name="percent">Percent of the way there</param>
        /// <returns></returns>
        public static Colour Lerp(Colour a, Colour b, float percent)
        {
            return new Colour(
                a.r + (b.r - a.r) * percent,
                a.g + (b.g - a.g) * percent,
                a.b + (b.b - a.b) * percent);
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
            /// Shorthand for creating a colour that goes between black and white
            /// </summary>
            /// <param name="a"></param>
            public Colour(int a)
            {
                a = Clamp(a, 0, 255);

                r = a;
                g = a;
                b = a;
            }

            /// <summary>
            /// Generate a new colour with alpha
            /// </summary>
            /// <param name="r"></param>
            /// <param name="g"></param>
            /// <param name="b"></param>
            /// <param name="a"></param>
            public Colour(int r, int g, int b, int a)
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

            /// <summary>
            /// Generate a new colour with alpha
            /// </summary>
            /// <param name="r"></param>
            /// <param name="g"></param>
            /// <param name="b"></param>
            public Colour(float r, float g, float b)
            {
                r = Clamp(r, 0, 255);
                g = Clamp(g, 0, 255);
                b = Clamp(b, 0, 255);
                a = Clamp(a, 0, 255);

                this.r = (int)r;
                this.g = (int)g;
                this.b = (int)b;
                a = 255;
            }

            /// <summary>
            /// Convert this to a string
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return string.Format("{0}, {1}, {2}", r, g, b);
            }
        }
    }
}