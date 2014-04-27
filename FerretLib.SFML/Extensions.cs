﻿using System.Drawing;
using SFML.Window;

namespace FerretLib.SFML
{
    public static class Extensions
    {
        #region Basic conversion
        public static Vector2i ToVector2i(this Vector2f input)
        {
            return new Vector2i((int)input.X, (int)input.Y);
        }

        public static Vector2f ToVector2f(this Vector2i input)
        {
            return new Vector2f(input.X, input.Y);
        }

        public static Point ToPoint(this Vector2i input)
        {
            return new Point(input.X, input.Y);
        }

        public static Point ToPoint(this Vector2f input)
        {
            return new Point((int)input.X, (int)input.Y);
        }

        public static Vector2f ToVector2f(this Size input)
        {
            return new Vector2f(input.Width, input.Height);
        }

        public static Vector2f ToVector2f(this Point input)
        {
            return new Vector2f(input.X, input.Y);
        }

        public static Vector2i ToVector2i(this Size input)
        {
            return new Vector2i(input.Width, input.Height);
        }

        public static Vector2i ToVector2i(this Point input)
        {
            return new Vector2i(input.X, input.Y);
        }
        #endregion

        public static Rectangle Normalize(this Rectangle rectangle)
        {
            return new Rectangle(0,0,rectangle.Width,rectangle.Height);
        }
    }
}
