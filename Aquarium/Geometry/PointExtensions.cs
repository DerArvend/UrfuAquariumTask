using System;
using System.Drawing;
using Aquarium.Fishes;
using Aquarium.Logic;
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

		public static Point Substract(this Point p1, Point p2)
		{
			return new Point(p1.X - p2.X, p1.Y - p2.Y);
		}

		public static bool IsNearBorder(this Point p, IAquarium aquarium, int radius = 1)
		{
			if (radius <=0)
				throw new ArgumentException("radius must be more than zero");
			if (radius >= Min(aquarium.Size.Height, aquarium.Size.Width))
				throw new ArgumentException("radius must be less than aquarium size");
			return p.X >= aquarium.Size.Width - radius ||
			       p.X <= radius ||
			       p.Y >= aquarium.Size.Height - radius ||
			       p.Y <= radius;
		}

		public static bool IsInSize(this Point p, Size size)
		{
			return p.X >= 0 && p.Y >= 0 && p.X < size.Width && p.Y < size.Height;
		}
	}
}