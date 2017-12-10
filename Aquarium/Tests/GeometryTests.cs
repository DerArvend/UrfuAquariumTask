using System;
using System.Drawing;
using System.Windows.Forms.VisualStyles;
using Aquarium.Geometry;
using NUnit.Framework;
using FluentAssertions;

namespace Aquarium.Tests
{
	[TestFixture]
	public class GeometryTests
	{
		[Test]
		public void DistanceShould_BeZeroForSamePoint()
		{
			new Point(0, 0).GetDistanceTo(new Point(0, 0)).Should().Be(0);
		}

		[Test]
		public void DistanceShould_BeSame_ForBothPoints()
		{
			var p1 = new Point(53, 12);
			var p2 = new Point(23, 89);
			p1.GetDistanceTo(p2).Should().Be(p2.GetDistanceTo(p1));
		}

		[TestCase(0, 0, 0, 1, 1)]
		[TestCase(2, 3, 5, 7, 5)]
		public void DistanceShould_WorkCorrectly(int x1, int y1, int x2, int y2, double expectedDistance)
		{
			MeasureDistance(x1, y1, x2, y2).Should().BeApproximately(expectedDistance, 0.001);
		}

		[Test]
		public void GetPolar_ShouldBeZero_ForZeroPoint()
		{
			var p = new Point(0, 0);
			p.GetPolarCoordinates().ShouldBeEquivalentTo((0, 0));
		}

		[Test]
		public void GetPolar_ShouldWorkCorrectly()
		{
			var p = new Point(1, 1);
			p.GetPolarCoordinates().ShouldBeEquivalentTo((Math.Sqrt(2), Math.PI / 4));
		}

		private static double MeasureDistance(int x1, int y1, int x2, int y2)
		{
			return new Point(x1, y1).GetDistanceTo(new Point(x2, y2));
		}
	}
}