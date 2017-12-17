using System.Drawing;

namespace Aquarium.Fishes
{
	public class FishFood : IGameObject
	{
		public Size Size { get; }
		public Point Location { get; }

		public void Update(IGame game)
		{
		}
	}
}