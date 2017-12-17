using System;
using System.Drawing;

namespace Aquarium.Geometry
{
    public static class PointExtensions
    {
        public static double GetDistanceTo(this Point p1, Point p2)
        {
            var xDistance = p2.X - p1.X;
            var yDistance = p2.Y - p1.Y;
            return Math.Sqrt(xDistance * xDistance + yDistance * yDistance);
        }
        public static (double length, double angle) GetPolarCoordinates(this Point p)
        {
            var len = Math.Sqrt(p.X * p.X + p.Y * p.Y);
            var ang = Math.Atan2(p.Y, p.X);
            return (len, ang);
        }
    }
}