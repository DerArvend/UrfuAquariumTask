using System;
using System.Drawing;

namespace Aquarium.Geometry
{
    public class Vector
    {
        public readonly double X;
        public readonly double Y;

        public Vector(Point p)
        {
            X = p.X;
            Y = p.Y;
        }

        public Vector(double length, double angle)
        {
            X = length * Math.Acos(angle);
            Y = -length * Math.Asin(angle);
        }

        public double Length => Math.Sqrt(X * X + Y * Y);

        public double Angle => Math.Atan2(Y, X);

        public static Vector Zero = new Vector(new Point(0, 0));

        public override string ToString()
        {
            return string.Format("X: {0}, Y: {1}", X, Y);
        }

        protected bool Equals(Vector other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(new Point((int)(a.X - b.X), (int)(a.Y - b.Y)));
        }

        public static Vector operator *(Vector a, double k)
        {
            return new Vector(new Point((int)(a.X * k), ((int)(a.Y * k))));
        }

        public static Vector operator /(Vector a, double k)
        {
            return new Vector(new Point((int)(a.X / k), (int)(a.Y / k)));
        }

        public static Vector operator *(double k, Vector a)
        {
            return a * k;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(new Point((int)(a.X + b.X), (int)(a.Y + b.Y)));
        }

        public Vector Normalize()
        {
            return Length > 0 ? this * (1 / Length) : this;
        }

        public Vector Rotate(double angle)
        {
            return new Vector(Length, (Angle + angle) % (2 * Math.PI));
        }

        public Vector BoundTo(Size size)
        {
            return new Vector(new Point(((int)(Math.Max(0, Math.Min(size.Width, X)))), (int)(Math.Max(0, Math.Min(size.Height, Y)))));
        }
        public Point ToPoint() => new Point((int)X, (int)Y);
    }
}