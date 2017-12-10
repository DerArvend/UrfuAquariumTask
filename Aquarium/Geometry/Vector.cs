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
			Y = length * Math.Asin(angle);
		}

		//TODO: Write other methods
	}
}
