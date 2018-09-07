using System;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using static ECS.MathC;

namespace ECS
{
    /// <summary>
    /// Graphics class
    /// </summary>
    public static class GFX
    {
        static List<Shape> shapeList = new List<Shape>();

        static GameWindow window;
        /// <summary>
        /// Amount of frames since start
        /// </summary>
        public static int framecount = 0;

        /// <summary>
        /// Wheter tobe in debug mode or not
        /// </summary>
        public static bool debug = false;
        
        /// <summary>
        /// Height and width of window
        /// </summary>
        public static int windowWidth, windowHeight;

        /// <summary>
        /// List of colours
        /// </summary>
        public static Colours colours;

        private static float thickness = 1;
        private static Color4 colour;

        private static Shape customShape;
        private static List<double> customX = new List<double>();
        private static List<double> customY = new List<double>();

        private static readonly int startFrequency = 60;

        /// <summary>
        /// Create a new graphics window
        /// </summary>
        /// <param name="width">Width in pixels of window</param>
        /// <param name="height">Height in pixels of window</param>
        /// <param name="title">Title of the window</param>
        /// <param name="OnFrameUpdate">Will be called every frame</param>
        /// <returns></returns>
        public static void CreateWindow(int width, int height, string title, EventHandler<FrameEventArgs> OnFrameUpdate)
        {
            windowWidth = width;
            windowHeight = height;
            window = new GameWindow(width, height, GraphicsMode.Default, title);
            window.Load += Window_Load;
            window.UpdateFrame += Window_RenderFrame;
            window.UpdateFrame += OnFrameUpdate;
            window.Resize += Window_Resize;
            window.Run(startFrequency);
        }


        /// <summary>
        /// Create a new graphics window
        /// </summary>
        /// <param name="width">Width in pixels of window</param>
        /// <param name="height">Height in pixels of window</param>
        /// <param name="title">Title of the window</param>
        /// <param name="onFrameUpdate">Will be called every frame</param>
        /// <param name="OnLoad">Will be called on load</param>
        /// <returns></returns>
        public static void CreateWindow(int width, int height, string title, EventHandler<FrameEventArgs> onFrameUpdate, EventHandler<EventArgs> OnLoad)
        {
            window = new GameWindow(width, height, GraphicsMode.Default, title);
            window.Load += Window_Load;
            window.UpdateFrame += onFrameUpdate;
            window.UpdateFrame += Window_RenderFrame;
            window.Load += OnLoad;
            window.Resize += Window_Resize;
            window.Run(startFrequency);
        }

        /// <summary>
        /// Create a new graphics window
        /// </summary>
        /// <param name="width">Width in pixels of window</param>
        /// <param name="height">Height in pixels of window</param>
        /// <param name="title">Title of the window</param>
        /// <param name="onFrameUpdate">Will be called every frame</param>
        /// <param name="OnLoad">Will be called on load</param>
        /// <param name="OnExit">Will be called when the window exits</param>
        /// <returns></returns>
        public static void CreateWindow(int width, int height, string title, EventHandler<FrameEventArgs> onFrameUpdate, 
            EventHandler<EventArgs> OnLoad, EventHandler<EventArgs> OnExit)
        {
            window = new GameWindow(width, height, GraphicsMode.Default, title);
            window.Load += Window_Load;
            window.UpdateFrame += onFrameUpdate;
            window.UpdateFrame += Window_RenderFrame;
            window.Load += OnLoad;
            window.Unload += OnExit;
            window.Resize += Window_Resize;
            window.Run(startFrequency);
        }

        /// <summary>
        /// Draw a circle
        /// </summary>
        /// <param name="x">X position of the circle</param>
        /// <param name="y">Y position of the circle</param>
        /// <param name="radius">Radius of the circle</param>
        public static void Circle(int x, int y, float radius)
        {
            double[] posX = new double[360];
            double[] posY = new double[360];

            float height = radius / windowHeight;
            float width = radius / windowWidth;

            for (int i = 0; i < 360; i++)
            {
                posX[i] = (Math.Cos(i) * width) + ((float)x / (windowWidth / 2)) - 1;
                posY[i] = (Math.Sin(i) * height) - ((float)y / (windowHeight / 2)) + 1;
            }

            shapeList.Add(new Shape(colour, PrimitiveType.Polygon, posX, posY));
        }


        /// <summary>
        /// Draw an elipse
        /// </summary>
        /// <param name="x">X Coord</param>
        /// <param name="y">Y Coord</param>
        /// <param name="rad1">Vertical radius</param>
        /// <param name="rad2">Horizontal radius</param>
        public static void Elipse(int x, int y, float rad1, float rad2)
        {
            double[] posX = new double[360];
            double[] posY = new double[360];

            float height = rad1 / windowHeight;
            float width = rad2 / windowWidth;

            for (int i = 0; i < 360; i++)
            {
                posX[i] = (Math.Cos(i) * width) + ((float)x / (windowWidth / 2)) - 1;
                posY[i] = (Math.Sin(i) * height) - ((float)y / (windowHeight / 2)) + 1;
            }

            shapeList.Add(new Shape(colour, PrimitiveType.Polygon, posX, posY));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radius"></param>
        /// <param name="degrees"></param>
        public static void Arc(int x, int y, float radius, int degrees)
        {
            double[] posX = new double[degrees];
            double[] posY = new double[degrees];

            float height = radius / windowHeight;
            float width = radius / windowWidth;

            for (int i = 0; i < degrees; i++)
            {
                posX[i] = (Math.Cos(i) * width);// + ((float)x / (windowWidth / 2)) - 1;
                posY[i] = (Math.Sin(i) * height);// - ((float)y / (windowHeight / 2)) + 1;
            }

            shapeList.Add(new Shape(colour, PrimitiveType.LineStrip, posX, posY));
        }

        /// <summary>
        /// Draw a line between x1,y1 and x2,y2
        /// </summary>
        public static void Line(int x1, int y1, int x2, int y2)
        {
            float posX1 = Map(x1, 0, windowWidth, -1, 1);
            float posY1 = Map(y1, 0, windowHeight, -1, 1) * -1;
            float posX2 = Map(x2, 0, windowWidth, -1, 1);
            float posY2 = Map(y2, 0, windowHeight, -1, 1) * -1;

            shapeList.Add(new Shape(colour, PrimitiveType.Lines, new double[] { posX1, posX2 }, new double[] { posY1, posY2 }));
        }

        /// <summary>
        /// Draw a square
        /// </summary>
        /// <param name="x">X coord</param>
        /// <param name="y">Y coord</param>
        /// <param name="sideLength">Length of each side</param>
        public static void Square(int x, int y, double sideLength)
        {
            double[] posX = new double[5];
            double[] posY = new double[5];

            posX[0] = x - (sideLength / 2);
            posY[0] = y - (sideLength / 2);

            posX[1] = x + (sideLength / 2);
            posY[1] = y - (sideLength / 2);

            posX[2] = x + (sideLength / 2);
            posY[2] = y + (sideLength / 2);

            posX[3] = x - (sideLength / 2);
            posY[3] = y + (sideLength / 2);

            posX[4] = x - (sideLength / 2);
            posY[4] = y - (sideLength / 2);

            for (int i = 0; i < 5; i++)
            {
                posX[i] = Map(posX[i], 0, windowWidth, -1, 1);
                posY[i] = Map(posY[i], 0, windowHeight, -1, 1);
            }

            shapeList.Add(new Shape(colour, PrimitiveType.Polygon, posX, posY));
        }

        /// <summary>
        /// Draw a rect
        /// </summary>
        /// <param name="x">X coord</param>
        /// <param name="y">Y coord</param>
        /// <param name="width">Width of the rect</param>
        /// <param name="height">Height of the rect</param>
        public static void Rect(int x, int y, double width, double height)
        {
            double[] posX = new double[5];
            double[] posY = new double[5];

            posX[0] = x - (width / 2);
            posY[0] = y - (height / 2);

            posX[1] = x + (width / 2);
            posY[1] = y - (height / 2);

            posX[2] = x + (width / 2);
            posY[2] = y + (height / 2);

            posX[3] = x - (width / 2);
            posY[3] = y + (height / 2);

            posX[4] = x - (width / 2);
            posY[4] = y - (height / 2);

            for (int i = 0; i < 5; i++)
            {
                posX[i] = Map(posX[i], 0, windowWidth, -1, 1);
                posY[i] = Map(posY[i], 0, windowHeight, -1, 1);
            }

            shapeList.Add(new Shape(colour, PrimitiveType.Polygon, posX, posY));
        }


        /// <summary>
        /// begin a new custom shape
        /// </summary>
        public static void BeginShape()
        {
            customShape = new Shape();
            customShape.p = PrimitiveType.Polygon;
        }
        
        /// <summary>
        /// Add a vertex to the shape
        /// </summary>
        /// <param name="x">X coord</param>
        /// <param name="y">Y coord</param>
        public static void Vertex(int x, int y)
        {
            customX.Add(x);
            customY.Add(y);
        }

        /// <summary>
        /// End the shape
        /// </summary>
        public static void EndShape()
        {
            customShape.posX = customX.ToArray();
            customShape.posY = customY.ToArray();

            customShape.c = colour;

            customX = new List<double>();
            customY = new List<double>();
            shapeList.Add(customShape);
        }

        /// <summary>
        /// Set background to a new colour;
        /// </summary>
        /// <param name="c">
        /// Colour of the background
        /// </param>
        public static void Background(Color4 c)
        {
            GL.ClearColor(c);
        }

        /// <summary>
        /// Set the thickness of the shapes you draw
        /// </summary>
        /// <param name="t">Thickness</param>
        public static void StrokeWeight(float t)
        {
            thickness = t;
        }

        /// <summary>
        /// Set the colour that things will be drawn in
        /// </summary>
        /// <param name="c"></param>
        public static void Colour(Color4 c)
        {
            colour = c;
        }

        /// <summary>
        /// Turn on or off Vsync
        /// </summary>
        /// <param name="vsync">
        /// Wether to use it or not
        /// </param>
        public static void UseVSync(bool vsync)
        {
            window.VSync = vsync ? VSyncMode.On : VSyncMode.Off;
        }

        /// <summary>s
        /// Close the window
        /// </summary>
        public static void DestroyWindow()
        {
            window.Close();
        }

        private static void Window_RenderFrame(object sender, FrameEventArgs e)
        {
            if (debug)
                Debug();

            framecount++;
            GL.Clear(ClearBufferMask.ColorBufferBit);

            foreach (Shape s in shapeList)
            {
                GL.Color4(s.c);
                GL.Begin(s.p);
                GL.LineWidth(thickness);

                for (int i = 0; i < s.posX.Length; i++)
                {
                    GL.Vertex2(s.posX[i], s.posY[i]);
                }
                GL.End();
            }

            GL.Flush();
            window.SwapBuffers();
            shapeList = new List<Shape>();
        }

        private static void Debug()
        {
            Console.WriteLine("Framecount: {0}", framecount);
        }

        private static void Window_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Program Started!");
            Console.WriteLine("Running at {0} FPS", startFrequency);

            GL.Viewport(0, 0, windowWidth, windowHeight);
            GL.ClearColor(Color4.Black);
        }

        private static void Window_Resize(object sender, EventArgs e)
        {
            windowHeight = window.Height;
            windowWidth = window.Width;
            Console.WriteLine("Resize Detected! New dimensions: {0} x {1}", windowWidth, windowHeight);
            
        }

      
    }

    class Shape
    {
        public PrimitiveType p;
        public Color4 c;
        public double[] posX;
        public double[] posY;

        public Shape(Color4 c, PrimitiveType p, double[] posX, double[] posY)
        {
            this.p = p;
            this.posX = posX;
            this.posY = posY;
            this.c = c;
        }

        public Shape()
        {

        }
    }

    /// <summary>
    /// Colours class
    /// </summary>
    public class Colours
    {
        /// <summary>
        /// Gray colour RGB = (128,128,128)
        /// </summary>
        public static Color4 Gray = Color4.Gray;
    }
}