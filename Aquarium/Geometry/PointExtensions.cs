using System;
using System.Drawing;
using static System.Math;

namespace Aquarium.Geometry
{
	public static class PointExtensions
	{
		public static double GetDistanceTo(this Point p1, Point p2)
		{
			var xDistance = p2.X - p1.X;
			var yDistance = p2.Y - p1.Y;
			return Sqrt(xDistance * xDistance + yDistance * yDistance);
		}

		public static (double length, double angle) GetPolarCoordinates(this Point p)
		{
			var len = Sqrt(p.X * p.X + p.Y * p.Y);
			var ang = Atan2(p.Y, p.X);
			return (len, ang);
		}

		public static Point MoveTo(this Point p, Point target, double length)
		{
			if (p.GetDistanceTo(target) < length)
				return target;
			var angle = Atan2(target.Y - p.Y, target.X - p.X);
			var dx = Cos(angle) * length;
			var dy = Sin(angle) * length;
			return new Point((int) dx + p.X, (int) dy + p.Y);
		}
	}
}