using System.Drawing;
using Aquarium.Logic;

namespace Aquarium.Fishes
{
	public class FishFood : IAquariumObject
	{
		public Size Size { get; }
		public Point Location { get; }
		public bool ShouldBeDestroyed { get; private set; }
		public void Destroy() => ShouldBeDestroyed = true;

		public FishFood(Point location, Size size)
		{
			Location = location;
			Size = size;
		}

		public void Update(IAquarium aquarium)
		{
		}
	}
}